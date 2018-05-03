using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCEP.Servico.Modelo; // deserializar
using Newtonsoft.Json;


namespace App01_ConsultarCEP.Servico
{
    public class ViaCEPServico
    {
        // busca endereco do site viacep.com.br
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(String cep)
        {
            string NovoEnderecoURL = String.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            String Conteudo = wc.DownloadString(NovoEnderecoURL); // metodo sincrono -- trava tela

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo); // converte o Json recebido da net em objeto

            return end;

        }

    }
}
