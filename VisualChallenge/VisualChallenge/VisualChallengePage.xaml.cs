using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public VisualChallengePage()
        {
            InitializeComponent();
            PostsCollectionView.ItemsSource = PostsData;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));
        }

        readonly List<PostData> PostsData = new List<PostData>
        {
            new PostData
            {
                Username = "mikeparker",
                PostTitle = "Lorem ipsum dolor",
                PostDetail = "sit amet consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua in culpa qui officia deserunt mollit",
                PostImage = "mt_rainier_milky_way",
                LikeCountText = "234,510 likes",
                CommentCountText = "2,717 comments",
                TimestampText = "25 MINUTES AGO"
            },
            new PostData
            {
                Username = "mikeparker",
                PostTitle = "Ut enim ad minim veniam",
                PostDetail = "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum sed do eiusmod tempor incididunt",
                PostImage = "lake_louise_canada",
                LikeCountText = "234,510 likes",
                CommentCountText = "2,717 comments",
                TimestampText = "25 MINUTES AGO"
            },
            new PostData
            {
                Username = "mikeparker",
                PostTitle = "Dolore eu fugiat nulla",
                PostDetail = "pariatur excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum ullamco laboris nisi ut aliquip",
                PostImage = "queensland_australia",
                LikeCountText = "234,510 likes",
                CommentCountText = "2,717 comments",
                TimestampText = "25 MINUTES AGO"
            }
        };
    }
}