using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico;
using App01_ConsultarCEP.Servico.Modelo;



namespace App01_ConsultarCEP
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;  // += contatenar e atribuir
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            // TODO - lógica do programa          
            string cep = CEP.Text.Trim();

            if (isValidCep(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);
                    if (end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço: {2}, {3}, {0}, {1}.", end.localidade, end.uf, end.logradouro, end.bairro);
                    }
                    else
                    {
                        DisplayAlert("ERRO", "O endereço não foi localizado", "OK");
                    }
                }
                catch(Exception e)
                {
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }

             
                
            }
            
        }
        // TODO - VALIDAÇOES ---------  VER DEPOIS VALICAÇÕES COM DATA ANOTATION
        private bool isValidCep(string cep)
        {
            bool valido = true;
            // verifica se tem 8 caracteres
            if(cep.Length != 8)
            {
                // ERRO
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter 8 caracteres", "OK");
                valido = false;               
            }
            int NovoCep = 0;

            if (!int.TryParse(cep, out NovoCep))   //TryParse  -- Tenta converter em inteiro  
            {
                // ERRO // caso não ocorra a conversao
                DisplayAlert("ERRO", "CEP inválido! O CEP deve ser composto apensas por números.", "OK");
                valido = false;              
            }
            return valido;
        }       

    }
}
