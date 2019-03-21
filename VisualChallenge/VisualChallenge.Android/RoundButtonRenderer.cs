using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(VisualChallenge.Android.RoundButtonRenderer), new[] { typeof(VisualChallenge.RoundButtonVisual) })]
namespace VisualChallenge.Android
{
    public class RoundButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Cleanup
            }

            if (e.NewElement != null)
            {
               Control.Background = null; // Required on Android otherwise button has a square background.
                //UIImage test = UIImage.FromFile("Hate.png");

                //Control.SetBackgroundImage(test, UIControlState.Normal);
                //Control.SetBackgroundImage(UIImage.FromFile("Love.png"), UIControlState.Selected);

                //Control.SetTitleShadowColor(Color.Black.ToUIColor(), UIKit.UIControlState.Normal);
            }
        }
    }
}
