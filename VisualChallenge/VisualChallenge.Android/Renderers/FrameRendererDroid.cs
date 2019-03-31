using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using VisualChallenge.Droid.Renderers;
using VisualChallenge;
using Android.Content;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(Frame), typeof(FrameRendererDroid), new[] { typeof(CustomVisual) })]
namespace VisualChallenge.Droid.Renderers
{
    public class FrameRendererDroid : FrameRenderer
    {
        public FrameRendererDroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            ViewGroup.SetBackgroundResource(Resource.Drawable.shadow_frame);
            ViewGroup.Elevation = 22;
        }
    }
}
