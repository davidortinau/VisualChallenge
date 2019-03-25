using System;
using System.Collections.ObjectModel;
using VisualChallenge.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        private ObservableCollection<Item> _items = new ObservableCollection<Item>();
        public ObservableCollection<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        private ObservableCollection<DashboardItem> _dashboardItems = new ObservableCollection<DashboardItem>();
        public ObservableCollection<DashboardItem> DashboardItems
        {
            get => _dashboardItems;
            set => _dashboardItems = value;
        }






        public VisualChallengePage()
        {
            InitializeComponent();

            BindingContext = this;

            PopulateData();


          
        }

        private void PopulateData()
        {
            Items.Add(new Item
            {
                Id = "1",
                Status = "Open",
                Subject = "Subject 123"
            });


            Items.Add(new Item
            {
                Id = "2",
                Status = "Open",
                Subject = "aaaaaaa cvvvvv"
            });


            Items.Add(new Item
            {
                Id = "3",
                Status = "Open",
                Subject = "Subject aaaaaa"
            });

            Items.Add(new Item
            {
                Id = "4",
                Status = "Open",
                Subject = "Subject aaaaaa"
            });


            Items.Add(new Item
            {
                Id = "5",
                Status = "Open",
                Subject = "Subject aaaaaa"
            });


            Items.Add(new Item
            {
                Id = "6",
                Status = "Open",
                Subject = "Subject aaaaaa"
            });





            DashboardItems.Add(new DashboardItem
            {
                 Number = "1,223",
                 Description ="Resolved Tickets",
                 ImageUrl = "https://cdn0.iconfinder.com/data/icons/material-circle-apps/512/icon-email-material-design-512.png"
            });

            DashboardItems.Add(new DashboardItem
            {
                Number = "12m",
                Description = "Avg. Response",
                ImageUrl = "https://cdn0.iconfinder.com/data/icons/social-15/200/hangouts-512.png"
            });

            DashboardItems.Add(new DashboardItem
            {
                Number = "11.7m",
                Description = "Issues",
                ImageUrl = "https://cdn3.iconfinder.com/data/icons/popular-services-brands-vol-2/512/trello-512.png"
            });

        





        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));
        }
    }
}