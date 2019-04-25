using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using VisualChallenge.Models;
using VisualChallenge.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewPage : ContentPage
    {
        public ObservableCollection<PokemonDetalleDto> PokemonList { get; set; }

        public CollectionViewPage()
        {
            InitializeComponent();
            GetPokemons();
        }

        private void GetPokemons()
        {
            try
            {
                var pokemonServices = Refit.RestService.For<IPokemonServices>("https://pokeapi.co/api/v2/");

                var response = pokemonServices.GetListPokemon().Result;

                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;
                    var lis = JsonConvert.DeserializeObject<PokemonDto>(jsonString);
                    PokemonList = new ObservableCollection<PokemonDetalleDto>(lis.PokemonDetalleDto.ToList());
                    listPage.ItemsSource = PokemonList;
                }
            }
            catch ( Exception ex) {
                Debug.Write("Error");
            }
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
