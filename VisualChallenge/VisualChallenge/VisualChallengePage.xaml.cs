using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
		ObservableCollection<MyItem> MyItems = new ObservableCollection<MyItem>();

		IList<MyItem> Data = new List<MyItem>()
		{
			new MyItem() { Name = "Carrots", ShortDescription = "Long orange things", Image = "http://befreshcorp.net/wp-content/uploads/2017/06/product-packshot-Carrot-558x600.jpg" },
			new MyItem() { Name = "Tomato", ShortDescription = "Round red...fruit?", Image = "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2014/8/19/0/HE_tomato-with-stem-thinkstock.jpg.rend.hgtvcom.616.493.suffix/1408469205509.jpeg" },
			new MyItem() { Name = "Bread", ShortDescription = "All the carbs", Image = "https://images-na.ssl-images-amazon.com/images/I/51fgwfyhrxL._SX425_.jpg" },
			new MyItem() { Name = "Apple", ShortDescription = "For the doctor", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTsxnZZoL7FC4FucFZo5ua8k39HRPg2PdbG1asTSAiO02UD4Y0Q" },
			new MyItem() { Name = "Chicken", ShortDescription = "He didn't make it across the road...", Image = "https://media.istockphoto.com/photos/chicken-and-egg-picture-id478796565?k=6&m=478796565&s=612x612&w=0&h=avEnw9FQbSl4l5RAbLK2oBMxvbRSbzxQ0PEVPTP2PvA=" }
		};

		public VisualChallengePage()
        {
            InitializeComponent();

			Results.ItemsSource = MyItems;
		}

		void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			MyItems.Clear();
			if (Data.Any(d => d.Name.Contains(e.NewTextValue)))
			{
				foreach (var item in Data.Where(d => d.Name.Contains(e.NewTextValue)))
					MyItems.Add(item);
			}
		}
	}

	class MyItem
	{
		public string Name { get; set; }

		public string ShortDescription { get; set;  }

		public string Image { get; set; }
	}
}