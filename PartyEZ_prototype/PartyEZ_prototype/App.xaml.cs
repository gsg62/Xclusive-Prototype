﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PartyEZ_prototype.Services;
using PartyEZ_prototype.Views;

namespace PartyEZ_prototype
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new OpeningPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
