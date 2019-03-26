using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {

        public string UserProfileImageUrl { get; set; }

        public List<Post> Posts { get; set; }

        public VisualChallengePage()
        {
            InitializeComponent();


            Posts = new List<Post>
            {
                new Post
                {
                    ProfileName = "David Ortinau",
                    ProfileImageUrl = "https://pbs.twimg.com/profile_images/812310411647205376/gxleSqEg_400x400.jpg",
                    PostedAgo = "5d",
                    ProfileJobTitle = "Star Program Manager, Mobile Dev Tools at Microsoft.",
                    Description = "flurry of entries for the #XamarinForms Visual Challenge. Thanks for helping us improve things! Latest submissions from: @brunocaceiro @nitescua @Chard003 djlorent @Cheesebaron HobDev",
                    ImageUrl = "https://pbs.twimg.com/media/DYGwImfVAAE1cHJ.jpg",
                    LikesName = "Chris Hardy",
                    CommentsCount = 3,
                    LikesCount = 15
                },

                new Post
                {
                    ProfileName = "Pierce Boggan",
                    ProfileImageUrl = "https://cdn-images-1.medium.com/max/1200/0*bbs98lWH7s9jC73k.",
                    PostedAgo = "6h",
                    ProfileJobTitle = "Program Manager Manager at Microsoft",
                    Description = "Excellent blog sharing some of the tips Microsoft's mobile customer advisory team has learned working with countless customers. Looking forward to more posts like this!",
                    ImageUrl = "https://pbs.twimg.com/media/DXs0GKIVAAEwFCZ.jpg:large",
                    LikesName = "Alex Blount",
                    CommentsCount = 3,
                    LikesCount = 15
                },

                new Post
                {
                    ProfileName = "Chris Hardy",
                    ProfileImageUrl = "http://thetabletshow.com/dnr_photos/chrishardy.jpg",
                    PostedAgo = "6h",
                    ProfileJobTitle = "Program Manager Manager at Microsoft ",
                    Description = "As part of the RBC Innovation & Entrepreneurship Speaker Series, I spoke with Michael Katchen Co-founder of Wealthsimple. The Q&A was part of UofT’s 3rd annual Entrepreneurship Week, the University of Toronto’s celebration of “all things entrepreneurship.” RBC is partners with UofT’s hashtag#ONRamp & Creative Destruction Lab & supports this series as well as the RBC Innovation Prize.",
                    ImageUrl = "https://blog.xamarin.com/wp-content/uploads/2016/05/Nat-keynote.jpg",
                    LikesName = "Pierce Boggan",
                    CommentsCount = 3,
                    LikesCount = 15
                },

                new Post
                {
                    ProfileName = "Michael Ridland",
                    ProfileImageUrl = "https://media.licdn.com/dms/image/C4E03AQGqQp0kKOGgHQ/profile-displayphoto-shrink_800_800/0?e=1559174400&v=beta&t=bevOW2245NyJ_CqWkjFqDizgUdf5lYpXBTXZRtQDX-4",
                    PostedAgo = "1mo",
                    ProfileJobTitle = "Father, Technical Director, Founder",
                    Description = "If your at Microsoft Ignite come past demo station 5. I’ll be giving a demo of building serverless and real-time systems using Cosmos DB, Functions and SignalR service.",
                    ImageUrl = "https://blog.xamarin.com/wp-content/uploads/2016/02/University.jpg",
                    LikesName = "David Ortinau",
                    CommentsCount = 3,
                    LikesCount = 15
                }
            };

            BindableLayout.SetItemsSource(ContentLayout, Posts);

            UserProfileImage.Source = "https://media.licdn.com/dms/image/C5603AQFQrLa724fv2A/profile-displayphoto-shrink_200_200/0?e=1559174400&v=beta&t=cTbbIMktRXv4cYrFC9XryeNFljy9e38nWIUGC3TgLD0";
        }

       


    }
}