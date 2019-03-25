using System;
using System.Collections.ObjectModel;

namespace VisualChallenge
{
    public class VisualChallengePageViewModel
    {
        public int GuestsQuantity { get; set; } = 1;
        public string UserName { get; set; }
        public ObservableCollection<Place> Places { get; set; }
        public ObservableCollection<PlaceType> PlaceTypes { get; set; }
        public VisualChallengePageViewModel()
        {
            Places = new ObservableCollection<Place>()
            {
                {new Place(){ Name="Charming Traditional House", Price=103, Photo="https://puu.sh/D58Wz/6d6d76734b.png", Tag="CULTURE"}},
                {new Place(){ Name="Home with Pool", Price=103, Photo="https://puu.sh/D58WN/1a1050e632.png", Tag="POOL"}},
                {new Place(){ Name="Full Apartament", Price=200, Photo="https://puu.sh/D58Xg/d8a6825af1.png", Tag="ROMANTIC"}}
            };


            PlaceTypes = new ObservableCollection<PlaceType>()
            {
                {new PlaceType(){ Name="Homes", Photo="https://puu.sh/D58FT/69a1d82e23.png"}},
                 {new PlaceType(){ Name="Experiences", Photo="https://puu.sh/D58Gg/5a285502b9.png"}},
                  {new PlaceType(){ Name="Restaurants", Photo="https://puu.sh/D58GX/f6e7317c6a.png"}}
            };
        }
    }
}
