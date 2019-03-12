using System;
using System.Collections.ObjectModel;
using VisualChallenge.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        private ObservableCollection<Story> _stories = new ObservableCollection<Story>();
        public ObservableCollection<Story> Stories
        {
            get => _stories;
            set => _stories = value;
        }

        private ObservableCollection<Bird> _nearbyBirds = new ObservableCollection<Bird>();
        public ObservableCollection<Bird> NearbyBirds
        {
            get => _nearbyBirds;
            set => _nearbyBirds = value;
        }

        public VisualChallengePage()
        {
            InitializeComponent();

            BindingContext = this;

            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/1600/public/news/european_turtle_dove_streptopelia_turtur_websitec_revital_salomon.jpg" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/little_spiderhunter_c_noicherrybeans_shutterstock_smaller_1.jpg" });
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/canada_warbler_c_jayne_gulbrand_smaller.jpg" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://cdn.images.express.co.uk/img/dynamic/13/590x/549233_1.jpg" });
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/rufous_hummingbird_selasphorus_rufus_c_ryan_bushby_1.jpg" });

            NearbyBirds.Add(new Bird() { Name = "Eagle", ImageUrl = "https://www.birdlife.org/sites/default/files/styles/1600/public/lesser-spotted-eagle-johann-du-preez.png" });
            NearbyBirds.Add(new Bird() { Name = "Golden eagle", ImageUrl = "https://www.birdlife.org/sites/default/files/styles/1600/public/golden_eagle_c_marc_jones_full_size.jpg" });
            NearbyBirds.Add(new Bird() { Name = "Bald eagle", ImageUrl = "https://www.birdlife.org/sites/default/files/styles/1600/public/skeeze-pixabay-bald-eagle-977811_1280_2.jpg" });
            NearbyBirds.Add(new Bird() { Name = "Imperial eagle", ImageUrl = "https://www.birdlife.org/sites/default/files/styles/1600/public/e_imperial_eagle_flickr.jpg" });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));
        }
    }
}