﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EXAppCenter
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void CrashBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                var a = 0;
                var b = 2 / a;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
