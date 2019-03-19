using Xamarin.Forms;

namespace VisualChallenge
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

#if DEBUG
            HotReloader.Current.Start(this);
#endif

            MainPage = new AppShell();
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
