﻿using System;
using VisualChallenge.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public VisualChallengePage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));
        }

        private async void Navigated_Clicked(object sender, EventArgs e)
        {
            var nextPage = new CollectionViewPage();

            await this.Navigation.PushAsync(nextPage);
        }
    }
}