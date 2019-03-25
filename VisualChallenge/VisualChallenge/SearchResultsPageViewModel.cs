using System.Windows.Input;
using VisualChallenge.Models;
using VisualChallenge.Services;
using Xamarin.Forms;

namespace VisualChallenge
{
    class SearchResultsPageViewModel : BindableBase
    {
        readonly IChuckNorrisFactService _factService;
        bool _isBusy;
        string _searchQuery;
        FactSearchResult _searchResult;

        public bool IsBusy { get => _isBusy; private set => SetProperty(ref _isBusy, value); }

        public string SearchQuery { get => _searchQuery; set => SetProperty(ref _searchQuery, value); }
        public FactSearchResult SearchResult { get => _searchResult; private set => SetProperty(ref _searchResult, value); }
        public ICommand SearchFactsCommand { get; private set; }

        public SearchResultsPageViewModel(IChuckNorrisFactService factService)
        {
            _factService = factService;
            SearchFactsCommand = new Command(ExecuteSearchFacts);
        }

        async void ExecuteSearchFacts()
        {
            SearchResult = null;

            if (string.IsNullOrWhiteSpace(SearchQuery))
                return;

            IsBusy = true;
            try
            {
                SearchResult = await _factService.Search(SearchQuery);
                SearchQuery = null;
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
