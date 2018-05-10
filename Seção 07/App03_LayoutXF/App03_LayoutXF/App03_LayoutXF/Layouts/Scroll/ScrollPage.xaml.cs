using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App03_LayoutXF.Layouts.Scroll
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScrollPage : ContentPage
    {
        public ScrollPage()
        {
            InitializeComponent();
        }

        Label label = new Label { Text = "Position: {lb}" };

        private void EnviaXY(String s){
            lb.Text += "X: " + scroll.ScrollX + "Y: " + scroll.ScrollY;
            if (scroll.ScrollY < -40)
            {
                Navigation.PopAsync();
            }
            
        }


        

}
}