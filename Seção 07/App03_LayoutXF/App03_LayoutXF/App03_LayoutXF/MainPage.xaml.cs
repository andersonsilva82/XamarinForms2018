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
        private void GoPageGrid(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Grid.GridPage());                   
        }

        private void GoPageAbsolute(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
        }

        private void GoPageRelative(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Relative.RelativePage());
        }

        private void GoPageScroll(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
        }
	}
}
