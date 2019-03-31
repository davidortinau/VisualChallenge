using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace VisualChallenge
{
    public partial class App : Xamarin.Forms.Application
    {

        public App()
        {
            InitializeComponent();
            var visualChallengePage = new VisualChallengePage()
            {
                Icon = "home.png"
            };
            var tabbedPage = new Xamarin.Forms.TabbedPage
            {
                Visual = VisualMarker.Material
            };
            tabbedPage.Effects.Add(Effect.Resolve("VisualChallenge.NoShiftEffect"));
            tabbedPage.On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            tabbedPage.Children.Add(visualChallengePage);
            NavigationPage.SetHasBackButton(visualChallengePage, false);
            tabbedPage.Children.Add(new ContentPage
            {
                Icon = "search.png"
            });
            tabbedPage.Children.Add(new ContentPage
            {
                Icon = "bell.png"
            });
            tabbedPage.Children.Add(new ContentPage
            {
                Icon = "message.png"
            });
            MainPage = new MasterDetailPage()
            {
                Master = new MasterPage(),
                Detail = tabbedPage
            }; 
            NavigationPage.SetHasNavigationBar(tabbedPage, false);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
