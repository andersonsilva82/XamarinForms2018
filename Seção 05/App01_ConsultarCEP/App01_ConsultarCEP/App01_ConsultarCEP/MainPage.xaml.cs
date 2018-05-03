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

            // TODO - VALIDAÇOES
            string cep = CEP.Text.Trim();
            Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

            RESULTADO.Text = string.Format("Endereço: {2}, {3}, {0}, {1}.", end.localidade, end.uf, end.logradouro, end.bairro);


        }
		
	}
}
