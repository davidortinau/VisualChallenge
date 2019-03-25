using VisualChallenge.Services;
using Xamarin.Forms;

namespace VisualChallenge
{
    public partial class SearchResultsPage : ContentPage
    {
        public SearchResultsPage()
        {
            InitializeComponent();

            var vm = new SearchResultsPageViewModel(
                Refit.RestService.For<IChuckNorrisFactService>("https://api.chucknorris.io"));
            BindingContext = vm;
        }
    }
}