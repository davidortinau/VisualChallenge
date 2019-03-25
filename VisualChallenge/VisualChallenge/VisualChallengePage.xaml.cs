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





        public VisualChallengePage()
        {
            InitializeComponent();

            BindingContext = this;



            Items.Add(new Item
            {
                Id = "1",
                Status ="Open",
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
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));
        }
    }
}