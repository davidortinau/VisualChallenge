﻿using Xamarin.Forms;

namespace VisualChallenge
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            
            MainPage = new HomePage();
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
