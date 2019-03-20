using UIKit;
using VisualChallenge.Visuals;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Label), typeof(VisualChallenge.iOS.Renderers.LabelRenderer), new[] { typeof(CheeseVisual) })]

namespace VisualChallenge.iOS.Renderers
{
    public class LabelRenderer : Xamarin.Forms.Platform.iOS.LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Control.BackgroundColor = UIColor.Yellow;
            Control.TextColor = UIColor.DarkGray;
        }
    }
}
