using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App03_LayoutXF
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void GoPageStack(object sender, EventArgs args)
        {
            try
            {
                Navigation.PushAsync(new Layouts.Stack.StackPage());
            }
            catch (Exception e)
            {
                DisplayAlert("Erro", e.Message, "Ok");
            }
            
        }
	}
}
