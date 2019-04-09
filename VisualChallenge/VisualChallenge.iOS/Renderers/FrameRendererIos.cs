using System;
using VisualChallenge;
using VisualChallenge.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;

[assembly:ExportRenderer(typeof(Frame), typeof(FrameRendererIos), new[] { typeof(CustomVisual) })]
namespace VisualChallenge.iOS.Renderers
{
    public class FrameRendererIos : FrameRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            if(Layer != null)
            {
                Layer.ShadowRadius = 8f;
                Layer.ShadowColor = Color.Silver.ToCGColor();
            }
        }
    }
}
