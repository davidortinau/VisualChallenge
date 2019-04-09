using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public ObservableCollection<BlogItem> BlogPosts { get; private set; }
        public VisualChallengePage()
        {
            InitializeComponent();
            BlogPosts = new ObservableCollection<BlogItem>();
            for (int i = 20; i > 0; i--)
            {
                BlogPosts.Add(new BlogItem(i));
            }
            BlogList.ItemsSource = BlogPosts;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));
        }
    }
}