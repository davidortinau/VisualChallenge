using System;

using Android.App;
using Android.Content.PM;
using Android.OS;

namespace VisualChallenge.Droid
{
    [Activity(Label = "VisualChallenge", Icon = "@mipmap/icon", Theme = "@style/MainTheme.Launcher", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        internal static Activity Current { get; private set; }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                TabLayoutResource = Resource.Layout.Tabbar;
                ToolbarResource = Resource.Layout.Toolbar;

                //SetStatusBarColor(global::Android.Graphics.Color.Black);
                Current = this;
                base.OnCreate(savedInstanceState);

                global::Xamarin.Forms.Forms.SetFlags("Shell_Experimental", "Visual_Experimental", "CollectionView_Experimental", "FastRenderers_Experimental");
                global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
                LoadApplication(new App());
            }
            catch (Exception ex )
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
    }
}