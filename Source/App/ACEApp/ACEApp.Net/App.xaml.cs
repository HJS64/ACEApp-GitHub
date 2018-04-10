using System;
using System.Collections.Generic;
using ACEApp.Net.ViewLayer.Pages;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace ACEApp.Net
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new StartPage();
        }

        protected override void OnStart()
        {
            base.OnStart();

            // Intialisation of Microsoft AppCenter: iOS and Droid
            AppCenter.Start("ios=cdab3353-65e9-415d-8711-6275c82b5874; android=fb82d4fa-27e8-48e5-87e0-217dd9c69b39;", typeof(Analytics), typeof(Crashes));
        }
    }
}
