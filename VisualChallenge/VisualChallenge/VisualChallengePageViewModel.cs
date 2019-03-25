using System.Collections.Generic;
using System.Windows.Input;
using VisualChallenge.Models;
using VisualChallenge.Services;
using Xamarin.Forms;

namespace VisualChallenge
{
    class VisualChallengePageViewModel : BindableBase
    {
        readonly IChuckNorrisFactService _factService;
        bool _isBusy = true;
        Fact _randomFact;
        string _category;
        IEnumerable<string> _categories;

        // Properties
        public bool IsBusy { get => _isBusy; private set => SetProperty(ref _isBusy, value); }
        public IEnumerable<string> Categories { get => _categories; private set => SetProperty(ref _categories, value); }
        public Fact RandomFact { get => _randomFact; private set => SetProperty(ref _randomFact, value); }
        public string Category { get => _category; set => SetProperty(ref _category, value); }

        // Commands
        public ICommand GetRandomFactCommand { get; private set; }
        public ICommand SearchFactsCommand { get; private set; }

        public VisualChallengePageViewModel(IChuckNorrisFactService factService)
        {
            _factService = factService;
            GetRandomFactCommand = new Command(ExecuteGetRandomFact);
            SearchFactsCommand = new Command(ExecuteSearchFacts);
        }

        public async void Initialize()
        {
            IsBusy = true;
            try
            {
                Categories = await _factService.GetCategories();
                RandomFact = await _factService.GetRandomFact(null);
            }
            finally
            {
                IsBusy = false;
            }
        }

        async void ExecuteGetRandomFact()
        {
            IsBusy = true;
            try
            {
                RandomFact = await _factService.GetRandomFact(Category);
            }
            finally
            {
                IsBusy = false;
            }
        }

        void ExecuteSearchFacts()
        {
            //(Application.Current.MainPage as Shell)
            //    .GoToAsync($"app://tailwindtraders/productcategory?id={typeId}", true);
        }
    }
}
