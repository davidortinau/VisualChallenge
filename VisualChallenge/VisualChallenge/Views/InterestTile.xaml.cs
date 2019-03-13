using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge.Views
{
    public partial class InterestTile : Frame
    {
        public static readonly BindableProperty HeadlineProperty = BindableProperty.Create(nameof(Headline), typeof(string), typeof(InterestTile));

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

        public static readonly BindableProperty TopicImageProperty = BindableProperty.Create(nameof(TopicImage), typeof(string), typeof(InterestTile));

        public string TopicImage
        {
            get
            {
                return (string)GetValue(TopicImageProperty);
            }
            set
            {
                SetValue(TopicImageProperty, value);
            }
        }
        public InterestTile()
        {
            InitializeComponent();
        }
    }
}