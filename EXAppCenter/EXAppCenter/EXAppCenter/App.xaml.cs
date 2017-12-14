using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace EXAppCenter
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new EXAppCenter.MainPage();
		}

		protected override void OnStart ()
		{
            AppCenter.Start("android=9d0235e4-bb0e-4d71-acba-cc4887eca2a7;" ,
                   typeof(Analytics), typeof(Crashes));
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
