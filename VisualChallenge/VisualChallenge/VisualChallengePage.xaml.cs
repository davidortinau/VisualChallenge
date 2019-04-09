using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        private int tapCount = 0;

        public VisualChallengePage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));
        }

        private void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            tapCount++;
            var frameSender = (Frame)sender;
            // watch the monkey go from color to black&white!

        }
    }
}