using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Activity> Activities { get; set; }

        public VisualChallengePage()
        {
            InitializeComponent();

            Users = new ObservableCollection<User>
            {
                new User { Name = "Matt E", PhotoUrl = "https://cdn.pixabay.com/photo/2015/01/08/18/29/entrepreneur-593358_960_720.jpg" },
                new User { Name = "Lizzie B", PhotoUrl = "https://cdn.pixabay.com/photo/2018/01/13/19/39/fashion-3080644__340.jpg" },
                new User { Name = "Cameron S", PhotoUrl = "https://cdn.pixabay.com/photo/2016/03/23/04/01/beautiful-1274056__340.jpg" },
                new User { Name = "Haley M", PhotoUrl = "https://cdn.pixabay.com/photo/2017/03/17/04/07/beautiful-2150881__340.jpg" },
                new User { Name = "John D", PhotoUrl = "https://cdn.pixabay.com/photo/2015/01/08/18/30/entrepreneur-593371_960_720.jpg" },
                new User { Name = "Steve J", PhotoUrl = "https://cdn.pixabay.com/photo/2016/09/24/03/20/passion-1690965__340.jpg" },
                new User { Name = "Michael J", PhotoUrl = "https://cdn.pixabay.com/photo/2016/03/27/17/40/black-and-white-1283231__340.jpg" },
                new User { Name = "Denzel W", PhotoUrl = "https://cdn.pixabay.com/photo/2017/06/26/02/47/people-2442565__340.jpg" }
            };

            Activities = new ObservableCollection<Activity>
            {
                new Activity { User = Users[5], Amount = 15 },
                new Activity { User = Users[6], Amount = 5 },
                new Activity { User = Users[7], Amount = 5 }
            };

            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));
        }
    }
}