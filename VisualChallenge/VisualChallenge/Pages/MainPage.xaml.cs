using System;
using System.Collections.Generic;
using System.Net.Http;
using Refit;
using VisualChallenge.Services;
using Xamarin.Forms;

namespace VisualChallenge.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var wykopApi = RestService.For<IWykopApi>(new HttpClient(new AuthenticatedHttpClientHandler()) { BaseAddress = new Uri("http://a.wykop.pl") } );
            var links = await wykopApi.GetLinks();

            CollectionView.ItemsSource = links;
        }
    }
}
