using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge.Views
{
    public partial class FeatureImageArticleTile : Frame
    {
        public static readonly BindableProperty FeaturedImageProperty = BindableProperty.Create(nameof(FeaturedImage), typeof(string), typeof(HorizontalNewsTile));

        public string FeaturedImage
        {
            get
            {
                return (string)GetValue(FeaturedImageProperty);
            }
            set
            {
                SetValue(FeaturedImageProperty, value);
            }
        }

        public static readonly BindableProperty HeadlineProperty = BindableProperty.Create(nameof(Headline), typeof(string), typeof(HorizontalNewsTile));

        public string Headline
        {
            get
            {
                return (string)GetValue(HeadlineProperty);
            }
            set
            {
                SetValue(HeadlineProperty, value);
            }
        }

        public static readonly BindableProperty CategoryProperty = BindableProperty.Create(nameof(Category), typeof(string), typeof(HorizontalNewsTile));

        public string Category
        {
            get
            {
                return (string)GetValue(CategoryProperty);
            }
            set
            {
                SetValue(CategoryProperty, value);
            }
        }

        public static readonly BindableProperty SourceProperty = BindableProperty.Create(nameof(Source), typeof(string), typeof(HorizontalNewsTile));

        public string Source
        {
            get
            {
                return (string)GetValue(SourceProperty);
            }
            set
            {
                SetValue(SourceProperty, value);
            }
        }

        public FeatureImageArticleTile()
        {
            InitializeComponent();
        }
    }
}