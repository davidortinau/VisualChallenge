using System;
using System.Collections.ObjectModel;
using VisualChallenge.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
	public partial class VisualChallengePage : ContentPage
	{
		private ObservableCollection<Feed> _feeds = new ObservableCollection<Feed>()
			{
				new Feed(){ Icon= "ic_group", Count = 12, Description = "Youtube", Name="Social", CountBackgroundColor="#0b67e7"},
				new Feed(){ Icon= "tag", Count = 18, Description = "Think with Google", Name="Promotions", CountBackgroundColor="#1f8e3f"},
				new Feed(){ Icon= "ic_forum", Count = 25, Description = "Google Play", Name="Forums", CountBackgroundColor="#892fd0"},
			};

		public ObservableCollection<Feed> Feeds
		{
			get { return _feeds; }
			set
			{
				_feeds = value;
				OnPropertyChanged("Feeds");
			}
		}

		private ObservableCollection<Email> _emails = new ObservableCollection<Email>()
			{
				new Email(){ Icon= "monkey_1", Subject = "Trip to Yosimite", Name="Cecilia, Nik", Body = "Check out  the planning doc...", Tag = "Trip", TagBackgroundColor ="#e5f3e9", TagTextColor="#1f8e3f", Date = "2:13 PM", Attachment = "Yosimite...", AttachmentIcon = "ic_description", AttachmentTextColor = "#0B67E7", CountName = 2},
				new Email(){ Icon= "dog", Subject = "Hello from Mexico!", Name="Jenna, Alan, me", Body="Check out this place that we're st...", Date = "1:40 PM", CountName = 3},
				new Email(){ Icon= "monkey_2", Subject = "Coffee-making class", Name="Jeroen, Tino", Body = "Hi, i made a reservati...", Tag = "Reservation", TagBackgroundColor = "#fef7e0", TagTextColor ="#f5b13c", Date = "1:40 PM", CountName = 2},
				new Email(){ Icon= "wolf", Subject = "Coffee-making class", Name="Jeroen, Tino", Body = "Hi, i made a reservati...", Tag = "Reservation", TagBackgroundColor = "#fef7e0", TagTextColor ="#f5b13c",  Date = "12:57 PM", CountName = 2},
			};

		public ObservableCollection<Email> Emails
		{
			get { return _emails; }
			set
			{
				_emails = value;
				OnPropertyChanged("Emails");
			}
		}

		public VisualChallengePage()
		{
			InitializeComponent();
			BindingContext = this;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));
		}
	}
}
