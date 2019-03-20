using System;
using CoreGraphics;
using UIKit;
using VisualChallenge.iOS.Renderers;
using VisualChallenge.Visuals;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Button), typeof(VisualChallenge.iOS.Renderers.ButtonRenderer), new[] { typeof(CheeseVisual) })]

namespace VisualChallenge.iOS.Renderers
{
    public class ButtonRenderer : Xamarin.Forms.Platform.iOS.ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            Control.BackgroundColor = UIColor.Yellow;
            Control.SetTitleColor(UIColor.Black, UIControlState.Normal);
            Control.SetTitleColor(UIColor.DarkGray, UIControlState.Highlighted);

            Control.TitleLabel.Font = UIKit.UIFont.FromName("Helvetica", 20);

            Control.SetImage(UIImage.FromBundle($"Cheese1"), UIControlState.Normal);
            Control.SetImage(UIImage.FromBundle($"Cheese2"), UIControlState.Highlighted);

            Control.ImageView.ContentMode = UIViewContentMode.ScaleAspectFit;
            Control.ImageEdgeInsets = new UIEdgeInsets(15.0f, 15.0f, 15.0f, 15.0f);

            Control.Layer.ShadowRadius = 8f;
            Control.Layer.ShadowColor = UIColor.DarkGray.CGColor;
            Control.Layer.ShadowOffset = new CGSize(2, 2);
            Control.Layer.ShadowOpacity = 0.8f;

            Control.TouchUpInside += Control_TouchUpInside;
            Control.TouchDown += Control_TouchDown;
        }

        private void Control_TouchDown(object sender, EventArgs e)
        {
            Control.Layer.ShadowRadius = 2f;
            Control.Layer.ShadowColor = UIColor.DarkGray.CGColor;
            Control.Layer.ShadowOffset = new CGSize(2, 2);
            Control.Layer.ShadowOpacity = 0.4f;
        }

        private void Control_TouchUpInside(object sender, EventArgs e)
        {
            Control.Layer.ShadowRadius = 8f;
            Control.Layer.ShadowColor = UIColor.DarkGray.CGColor;
            Control.Layer.ShadowOffset = new CGSize(2, 2);
            Control.Layer.ShadowOpacity = 0.8f;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                if (Control != null)
                {
                    Control.TouchUpInside -= Control_TouchUpInside;
                    Control.TouchDown -= Control_TouchDown;
                }
            }
        }
    }
}
