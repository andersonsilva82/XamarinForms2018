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
	public partial class ProgressBarPage : ContentPage
	{
		public ProgressBarPage ()
		{
			InitializeComponent ();
		}

        private async void ModificarBarra1()
        {
            bar1.Progress = 0;

            for (int i = 0; i <= 10; i++)
            {
                bar1.Progress += .1;
                await Task.Delay(5000);                              
            }            
        }
        private void ModificarBarra2()
        {
            bar2.Progress = 0;
            bar2.ProgressTo(1, 5000, Easing.Linear);
        }
        private void ModificarBarra3()
        {
            bar3.Progress = 0;
            bar3.ProgressTo(1, 5000, Easing.SinInOut);
        }

    }
}