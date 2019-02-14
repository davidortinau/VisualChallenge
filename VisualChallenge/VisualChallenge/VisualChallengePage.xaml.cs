using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public VisualChallengePage()
        {
            InitializeComponent();
            BindingContext = new VisualViewModel();
        }

        async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (!(e.Item is Items items))
                return;

            await DisplayAlert("The place", $"You selected {items.Description}", "ok");

            (sender as ListView).SelectedItem = null;
        }
    }
}