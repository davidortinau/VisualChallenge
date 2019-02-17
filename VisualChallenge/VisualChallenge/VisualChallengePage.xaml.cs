using Xamarin.Forms;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public VisualChallengePage()
        {
            InitializeComponent();

            BindingContext = new VisualChallengeViewModel();

            scrollView.Scrolled += OnScroll;
        }

        protected override void OnAppearing()
        {
            scrollView.ScrollToAsync(0, 0, false);
        }

        void OnScroll(object sender, ScrolledEventArgs e)
        {
            if (e.ScrollY < Y)
                scrollView.ScrollToAsync(0, 0, false);
        }

    }
}