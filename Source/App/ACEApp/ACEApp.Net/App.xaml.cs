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
            AppCenter.Start("ios=cdab3353-65e9-415d-8711-6275c82b5874; android=43f0768f-181e-45a5-a6f7-0f87f8c8e801;", typeof(Analytics), typeof(Crashes));
        }
    }
}
