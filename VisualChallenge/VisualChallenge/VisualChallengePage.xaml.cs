using System;
using VisualChallenge.Visuals;
using Xamarin.Forms;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public VisualChallengePage()
        {
            InitializeComponent();
        }

        private int _count = 1;

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = new Button
            {
                Visual = new CheeseVisual(),
                Text = $"Button {_count++}",
                Margin = new Thickness(0, 10, 0, 10)
            };

            Root.Children.Add(button);
        }
    }
}