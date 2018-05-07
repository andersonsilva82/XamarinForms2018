using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Tabbed
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Abas : TabbedPage
	{
		public Abas ()
		{
			InitializeComponent ();

            // incluindo tab por c#
            Children.Add(new NavigationPage(new TipoPagina.Navegation.Pagina1()) {  Title = "item 3"});
		}
	}
}