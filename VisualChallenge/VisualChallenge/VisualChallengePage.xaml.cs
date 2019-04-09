using VisualChallenge.Model;
using Xamarin.Forms;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public VisualChallengePage()
        {
            InitializeComponent();
            BindingContext = new VisualChallengePageModel();
        }
    }
}