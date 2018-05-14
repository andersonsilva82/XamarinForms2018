using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BoxViewPage : ContentPage
	{
		public BoxViewPage ()
		{
			InitializeComponent ();
		}

        private void MudaOpacity()
        {
            boxView1.Opacity =+ 10;
            if (boxView1.IsVisible)
                boxView1.IsVisible = false;
            else
                boxView1.IsVisible = true;
        }
	}
}