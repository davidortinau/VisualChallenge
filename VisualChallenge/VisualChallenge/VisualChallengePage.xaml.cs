using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace VisualChallenge
{
	public partial class VisualChallengePage : ContentPage
	{
		private double carouselItemHeight;

		public VisualChallengePage()
		{
			InitializeComponent();

			CarouselItems = new CarouselItem[]
			{
				new CarouselItem {
					Thumbnail = "thumbnail1.jpg",
                    Avatar = "https://mixer.com/api/v1/users/230928/avatar?w=128&h=128"
				},
				new CarouselItem {
					Thumbnail = "thumbnail2.jpg",
                    Avatar = "https://mixer.com/api/v1/users/59366910/avatar?w=128&h=128"
				},
				new CarouselItem {
					Thumbnail = "thumbnail3.jpg",
				    Avatar = "https://mixer.com/api/v1/users/21101171/avatar?w=128&h=128"
				},
				new CarouselItem {
					Thumbnail = "thumbnail4.jpg",
					Avatar = "https://mixer.com/api/v1/users/230928/avatar?w=128&h=128"
				},
				new CarouselItem {
					Thumbnail = "thumbnail5.jpg",
					Avatar = "https://mixer.com/api/v1/users/59366910/avatar?w=128&h=128"
				},
				new CarouselItem {
					Thumbnail = "thumbnail6.jpg",
					Avatar = "https://mixer.com/api/v1/users/21101171/avatar?w=128&h=128"
				},
				new CarouselItem {
					Thumbnail = "thumbnail7.jpg",
					Avatar = "https://mixer.com/api/v1/users/230928/avatar?w=128&h=128"
				}
			};

			BindingContext = this;

			SizeChanged += OnSizeChanged;
		}

		public IEnumerable<CarouselItem> CarouselItems { get; }

		public double CarouselItemHeight
		{
			get => carouselItemHeight;
			private set
			{
				carouselItemHeight = value;
				OnPropertyChanged(nameof(CarouselItemHeight));
			}
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			OnSizeChanged(this, EventArgs.Empty);
		}

		private void OnSizeChanged(object sender, EventArgs e)
		{
			var itemWidth = Width * 0.6;
			CarouselItemHeight = itemWidth * 0.8;

			foreach (var item in CarouselItems)
			{
				item.ImageWidth = itemWidth;
			}
		}
	}

	public class CarouselItem : BindableObject
	{
		private static Random rnd = new Random();

		private double imageWidth;

		public string UserName { get; set; } = "CoolUserName";

		public string GameName { get; set; } = "The Game";

		public int ViewCount { get; set; } = rnd.Next(999);

		public string Thumbnail { get; set; }

        public string Avatar { get; set; }

		public double ImageWidth
		{
			get => imageWidth;
			set
			{
				imageWidth = value;
				OnPropertyChanged(nameof(ImageWidth));
			}
		}
	}
}
