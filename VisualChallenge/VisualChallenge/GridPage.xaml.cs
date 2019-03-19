using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridPage : ContentPage
	{
		public GridPage ()
		{
			InitializeComponent ();
            LoadLayout();
		}

        private void LoadLayout()
        {
            FlexLayout.Children.Clear();

            for (int index = 0; index < 10; index++)
            {
                var frame = new Frame
                {
                    Margin = new Thickness(5),
                    BorderColor = Color.MediumAquamarine,
                    VerticalOptions = new LayoutOptions(LayoutAlignment.Center, true)
                };

                var stacklayout = new StackLayout();

                var tapGesture = new TapGestureRecognizer();
                tapGesture.Tapped += async (s, e) => await Navigation.PushAsync(new VisualChallengePage());
                stacklayout.GestureRecognizers.Add(tapGesture);

                stacklayout.Children.Add(new Label
                {
                    HorizontalOptions = new LayoutOptions(LayoutAlignment.Center,true),
                    HorizontalTextAlignment = TextAlignment.Center,
                    Text = index == 0 ? "New Item" : "Hello World"
                });

                stacklayout.Children.Add(new Image
                {
                    WidthRequest = 100,
                    Source = index == 0 ?
                        "add" :
                        index % 2 == 0 ? "https://www.xpand-it.com/wp-content/uploads/2017/11/Xamarin-BootCamp-Portugal.png" : "https://cdn.dribbble.com/users/50332/screenshots/5822811/monkey_barrel.png"
                });

                frame.Content = stacklayout;
                FlexLayout.Children.Add(frame);
            }
        }
    }
}