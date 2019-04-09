using System;
using Xamarin.Forms;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
namespace VisualChallenge
{
    public class VisualChallengePageViewModel
    {
        private static readonly string RESOURCES = "VisualChallenge.Resources.";

        public ImageSource CoverPhoto { get; } = ImageSource.FromResource(RESOURCES + "cover_photo.jpg");
        public ImageSource HelpIcon { get; } = ImageSource.FromResource(RESOURCES + "ic_help.png");
        public ImageSource BellIcon { get; } = ImageSource.FromResource(RESOURCES + "ic_bell.png");
        public ImageSource ProfilePhoto { get; } = ImageSource.FromResource(RESOURCES + "profile_photo.png");


        public ObservableCollection<ImageSource> ShowsList { get; }
        public ObservableCollection<ImageSource> FavouriteShowsList { get; }
        public ObservableCollection<MiscObject> MiscObjectsList { get; }

        public VisualChallengePageViewModel()
        {
            ShowsList = new ObservableCollection<ImageSource>
            {
                ImageSource.FromResource(RESOURCES + "dark.jpg"),
                ImageSource.FromResource(RESOURCES + "mirror.jpg"),
                ImageSource.FromResource(RESOURCES + "peaky.jpg"),
                ImageSource.FromResource(RESOURCES + "leftovers.jpg"),
                ImageSource.FromResource(RESOURCES + "umbrella.jpg")
            };
            FavouriteShowsList = new ObservableCollection<ImageSource>(ShowsList.Reverse());
            MiscObjectsList = new ObservableCollection<MiscObject>
            {
                new MiscObject{ Title = "Custom lists" , Count = 3},
                new MiscObject{ Title = "Followers" , Count = 16},
                new MiscObject{ Title = "Followings" , Count = 18},
                new MiscObject{ Title = "Comments" , Count = 34},
                new MiscObject{ Title = "Stats" , Count = 2}
            };
        }

    }
    public class MiscObject
    {
        public string Title { get; set; }
        public int Count { get; set; }
    }
}

