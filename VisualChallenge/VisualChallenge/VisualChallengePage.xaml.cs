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
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));
        }

        void Expand_Clicked(object sender, System.EventArgs e)
        {
            Global.IsVisible = true;
            Neighbours.IsVisible = true;
            NeighbourLabel.IsVisible = true;
            Expand.IsVisible = false;
        }

        void Clear_Clicked(object sender, System.EventArgs e)
        {
            Global.IsVisible = false;
            Neighbours.IsVisible = false;
            NeighbourLabel.IsVisible = false;
            Expand.IsVisible = true;
            DateField.Text = String.Empty;
        }
    }
}