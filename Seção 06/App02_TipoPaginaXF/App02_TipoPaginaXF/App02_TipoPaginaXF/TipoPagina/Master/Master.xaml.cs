using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void MudarPagina1(Object sender, EventArgs args)
        {
            Detail = new Navegation.Pagina1();
            IsPresented = false; // Esconde o menu quando clica no botao
        }
        private void MudarPagina2(Object sender, EventArgs args)
        {
            Detail = new Navegation.Pagina1();
            IsPresented = false; // Esconde o menu quando clica no botao
        }
        private void MudarConteudo(Object sender, EventArgs args)
        {
            Detail = new Conteudo();
            IsPresented = false; // Esconde o menu quando clica no botao
        }

    }
}