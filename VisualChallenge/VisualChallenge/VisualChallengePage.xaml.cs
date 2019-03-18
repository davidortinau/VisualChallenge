using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public VisualChallengePage()
        {
            InitializeComponent();
            BindingContext = new VisualChallengeViewModel();

            //CarouselView.ItemsSource = new[] { "photo", "https://www.xpand-it.com/wp-content/uploads/2017/11/Xamarin-BootCamp-Portugal.png", "https://cdn.dribbble.com/users/50332/screenshots/5822811/monkey_barrel.png", "https://cdn.ttgtmedia.com/ITKE/cwblogs/open-source-insider/1onkey.png" };
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("SAVE", "Save the form?", "OK", "Cancel");
        }

        private async void Reset_Clicked(object sender, EventArgs e)
        {

            var isResetting = await DisplayAlert("RESET", "Reset the form?", "OK", "Cancel");
            if (isResetting)
            {
                Title.Text = string.Empty;
                Date.Date = DateTime.Now;
                Description.Text = string.Empty;
            }
        }
    }

    public class VisualChallengeViewModel
    {
        public VisualChallengeViewModel()
        {
            Images = new ObservableCollection<string>();
            Images.Add("photo");
            Images.Add("https://www.xpand-it.com/wp-content/uploads/2017/11/Xamarin-BootCamp-Portugal.png");
            Images.Add("https://cdn.dribbble.com/users/50332/screenshots/5822811/monkey_barrel.png");
            Images.Add("https://cdn.ttgtmedia.com/ITKE/cwblogs/open-source-insider/1onkey.png");
        }

        public ICommand SelectItem => new Command<string>(OnSelectItem);
        public ObservableCollection<string> Images { get; }

        private void OnSelectItem(string imageName)
        {
            if (imageName == "photo")
            {
                // todo - open the camera and take a photo, add it to the Images
                Images.Insert(1, "https://cdn.ttgtmedia.com/ITKE/cwblogs/open-source-insider/1onkey.png");
            }
        }
    }
}