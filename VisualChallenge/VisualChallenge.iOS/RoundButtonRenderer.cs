using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(VisualChallenge.iOS.RoundButtonRenderer), new[] { typeof(VisualChallenge.RoundButtonVisual) })]
namespace VisualChallenge.iOS
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
                //Control.TitleShadowOffset = new CoreGraphics.CGSize(1, 1);
                UIImage normal = UIImage.FromFile("Disabled.png");
                UIImage enabled = UIImage.FromFile("Enabled.png");

                Control.SetBackgroundImage(normal, UIControlState.Normal);
                Control.SetBackgroundImage(enabled, UIControlState.Highlighted);
                Control.ShowsTouchWhenHighlighted = false;
                Control.AdjustsImageWhenHighlighted = false;
                Control.ImageEdgeInsets = UIEdgeInsets.Zero;

                //Control.SetBackgroundImage(UIImage.FromFile("Love.png"), UIControlState.Selected);

                // Control.SetTitleShadowColor(Color.Black.ToUIColor(), UIKit.UIControlState.Normal);
            }
        }
    }
}
