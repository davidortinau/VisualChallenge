using System;
using Android.Content;
using VisualChallenge.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SearchBar), typeof(ExtendedSearchBar))]
namespace VisualChallenge.Droid
{
    public class ExtendedSearchBar: SearchBarRenderer
    {
        public ExtendedSearchBar(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            if(this.Control!= null)
            {
                var searchId = Resources.GetIdentifier("android:id/search_plate", null, null);
                var search = Control.FindViewById(searchId);
                search.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }

        }
    }
}
