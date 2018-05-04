using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Navegation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina1 : ContentPage
	{
		public Pagina1 ()
		{
			InitializeComponent ();
		}

        private void MudarParaPagina2(object sender, EventArgs args)
        {
            // Esta forma de chamar a página mantem o histórico - somente para navigation 
            Navigation.PushAsync(new Pagina2());
        }

        private void ChamarModal(object sender, EventArgs args)
        {
            // Esta forma de chamar a página mantem o histórico - somente para navigation 
            Navigation.PushModalAsync(new Modal());
        }
    }
}