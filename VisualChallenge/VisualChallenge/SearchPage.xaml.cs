using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
            Shell.SetSearchHandler(this, new FeedSearchHandler());
        }
    }

    public class FeedSearchHandler : SearchHandler
    {
        public FeedSearchHandler()
        {
            SearchBoxVisibility = SearchBoxVisiblity.Expanded;
            IsSearchEnabled = true;
            ShowsResults = true;
            Placeholder = "Search";
        }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
            //if (string.IsNullOrEmpty(newValue))
            //{
            //    ItemsSource = null;
            //}
            //else
            //{
            //    var results = new List<string>();
            //    results = App.Seashells.Where(x => x.Text.IndexOf(newValue, StringComparison.InvariantCultureIgnoreCase) > -1).Select(x => x.Text).ToList<string>();
            //    ItemsSource = results;
            //}
        }
    }
}