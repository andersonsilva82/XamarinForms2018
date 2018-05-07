using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}

        private void MudarPagina(object sender, EventArgs args)
        {
            // App.Current.MainPage = new Navegation.Pagina1(); // forma de  chamar sem instanciar a NavigationPAge
            // Não funciona para paginas depois que tem navigationpage gera exception

            //App.Current.MainPage = new NavigationPage(new Navegation.Pagina1()) { BarBackgroundColor = Color.BlueViolet };            
            App.Current.MainPage = new Tabbed.Abas();
            // aqui é como se fosse uma pagina dentro de outra
        }

        

    }
}