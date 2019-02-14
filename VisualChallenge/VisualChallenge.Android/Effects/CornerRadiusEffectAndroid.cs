using System.ComponentModel;
using Android.Graphics;
using Android.Views;
using VisualChallenge.Droid.Effects;
using VisualChallenge.Effect;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ResolutionGroupName("PJ")]
[assembly: ExportEffect(typeof(CornerRadiusEffectAndroid), nameof(CornerRadiusEffect))]


namespace VisualChallenge.Droid.Effects
{
    public class CornerRadiusEffectAndroid : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                PrepararContainer();
                SetarRaio();
            }
            catch { }
        }

        protected override void OnDetached()
        {
            try
            {
                Container.OutlineProvider = ViewOutlineProvider.Background;
            }
            catch { }
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == CornerRadiusEffect.CornerRadiusProperty.PropertyName)
                SetarRaio();
        }

        private void PrepararContainer()
        {
            Container.ClipToOutline = true;
        }

        private void SetarRaio()
        {
            var cornerRadius = CornerRadiusEffect.GetCornerRadius(Element) * GetDensity();
            Container.OutlineProvider = new RoundedOutlineProvider(cornerRadius);
        }

        private static float GetDensity() =>
            MainActivity.Current.Resources.DisplayMetrics.Density;

        private class RoundedOutlineProvider : ViewOutlineProvider
        {
            private readonly float _raio;

            public RoundedOutlineProvider(float raio) =>
                _raio = raio;

            public override void GetOutline(Android.Views.View view, Outline outline) =>
                outline?.SetRoundRect(0, 0, view.Width, view.Height, _raio);
        }
    }
}