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
      
        private async void OnPhoto_Clicked(object sender, EventArgs e)
        {
            string[] options = new string[] { "Open Camera", "Gallery" };
            var result = await DisplayActionSheet("Imagen", "Cancel", null, options);
            if (result == "Open Camera")
            {
               await DisplayAlert("Options" ,"Camera Selected", "Cancel");
            }
            if (result == "Gallery")
            {
                await DisplayAlert("Options", "Gallery","Cancel");
            }
        }
    }
}