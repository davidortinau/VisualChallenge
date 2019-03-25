using VisualChallenge.Services;
using Xamarin.Forms;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public VisualChallengePage()
        {
            InitializeComponent();

            var vm = new VisualChallengePageViewModel(
                Refit.RestService.For<IChuckNorrisFactService>("https://api.chucknorris.io"));
            BindingContext = vm;

            vm.Initialize();
        }
    }
}