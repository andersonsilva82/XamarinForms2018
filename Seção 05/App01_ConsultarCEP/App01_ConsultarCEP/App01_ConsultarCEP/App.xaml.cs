using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App01_ConsultarCEP
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            // App.Current.MainPage = atribuir nova pagina ao aplicativo 
			MainPage = new App01_ConsultarCEP.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
