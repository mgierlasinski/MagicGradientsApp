﻿using MagicGradientsApp.Pages;
using Xamarin.Forms;

namespace MagicGradientsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MagicGradients.Initializer.Init();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
