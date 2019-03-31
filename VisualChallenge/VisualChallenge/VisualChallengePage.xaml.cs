using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public List<Tweet> Tweets { get; } = new List<Tweet>();

        public VisualChallengePage()
        {
            for (int i = 0; i < 20; i++)
            {
                Tweets.Add(Faking.Faker.Default.Create<Tweet>());
                Tweets.Last().FullUserName = string.Join(" ", Tweets.Last().FullUserName.Split(' ').Take(3));
                Tweets.Last().RetweetedBy = string.Join(" ", Tweets.Last().RetweetedBy.Split(' ').Take(3));
                Tweets.Last().User = string.Join("", Tweets.Last().User.Split(' ').Take(2));
            }
            InitializeComponent();
            BindingContext = this;
        } 

        private void ClickGestureRecognizer_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Tweeet", "Twwwwwet", "Tweeet!");
        }
    }
}