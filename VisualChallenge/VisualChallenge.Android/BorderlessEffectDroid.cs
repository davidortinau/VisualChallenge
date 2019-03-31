using System.ComponentModel;
using Android.Widget;
using VisualChallenge.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("companyname")]
[assembly: ExportEffect(typeof(BorderlessEffectDroid), "BorderlessSearchEffect")]
namespace VisualChallenge.Droid
{
    public class BorderlessEffectDroid : PlatformEffect
    {
        protected override void OnAttached()
        {
            UpdateHasBorder();
        }

        protected override void OnDetached()
        {

        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName == BorderlessEffect.HasBorderProperty.PropertyName)
                UpdateHasBorder();
        }

        private void UpdateHasBorder()
        {
            var searchbar = Control as SearchView;
            if (searchbar == null)
                return;

            var bHasBorder = (bool)Element.GetValue(BorderlessEffect.HasBorderProperty);

            if (!bHasBorder)
            {
                int searchPlateId = searchbar.Context.Resources.GetIdentifier("android:id/search_plate", null, null);
                Android.Views.View searchPlateView = searchbar.FindViewById(searchPlateId);
                searchPlateView.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }
        }
    }
}