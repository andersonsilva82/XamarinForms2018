using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_Xamarin.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        private void GoPerfil1(object sender, EventArgs args)
        {

            Detail = new Pages.Perfil1();
            IsPresented = false;
            //Navigation.PushAsync(new Pages.Perfil1());
        }

        private void GoSobre(object sender, EventArgs args)
        {
            Detail = new Pages.Xamarin();
            IsPresented = false;
            //Navigation.PushAsync(new Pages.Xamarin());
        }

    }
}