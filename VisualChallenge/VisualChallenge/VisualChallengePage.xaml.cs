using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public class Story
        {
            public string Title { get; set; }
            public string Subtitle { get; set; }
            public string Publisher { get; set; }
            public string ImageUrl { get; set; }
            public string Subject { get; set; }
            public string Length { get; set; }
            public string PublishedAt { get; set; }
            private string fullDetails;
            public string FullDetails
            {
                get { return $"{PublishedAt} · {Length}"; }
            }
        }

        public VisualChallengePage()
        {
            InitializeComponent();

            List<Story> stories = new List<Story>();
            stories.Add(new Story
            {
                Title = "The Largest Esports Arena in the Western Hemisphere is Coming",
                Subtitle = "“Fusion Arena” will seat up to 3,500 guests. Construction is planned to start this summer.",
                Publisher = "Zane Bhansali",
                ImageUrl = "https://cdn-images-1.medium.com/max/2400/1*HhzJOwLU-7K6mdJ3LYPvOA.jpeg",
                Subject = "BUSINESS",
                Length = "5 min read",
                PublishedAt = "a few hours ago"
            });
            stories.Add(new Story
            {
                Title = "10 Lessons I’ve Learned From Traveling The World For 3 Years",
                Subtitle = "1. You’re Going To Look Like An Idiot\u200a—\u200aJust Accept It",
                Publisher = "Tom Kuegler",
                ImageUrl = "https://cdn-images-1.medium.com/max/1600/0*bbql2vc55O2zLvXN",
                Subject = "TRAVEL",
                Length = "6 min read",
                PublishedAt = "Mar 12"
            });
            stories.Add(new Story
            {
                Title = "How to Make Your First Billion by Riding the Tech Backlash",
                Subtitle = "People increasingly want what our over-computerized world completely lacks: privacy, predictability, and durability",
                Publisher = "Inc. Magazine",
                ImageUrl = "https://cdn-images-1.medium.com/max/2400/1*DIn9RC7HDoiDgpxx91Q7iQ.jpeg",
                Subject = "BUSINESS",
                Length = "4 min read",
                PublishedAt = "Mar 25"
            });
            stories.Add(new Story
            {
                Title = "I started taking five-minute breaks once every hour, and here’s what happened",
                Subtitle = "Like most people, I work 40 hour work weeks. This means that in a typical day, I spend 8 hours working",
                Publisher = "Mist_Connections",
                ImageUrl = "https://cdn-images-1.medium.com/max/1600/1*9ZJ5_rfw1OKB7bXCRRE1dw.jpeg",
                Subject = "BASED ON YOUR READING HISTORY",
                Length = "3 min read",
                PublishedAt = "Nov 28, 2018"
            });

            storiesListView.ItemsSource = stories;
        }
    }
}