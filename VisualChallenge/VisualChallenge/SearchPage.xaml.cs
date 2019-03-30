using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualChallenge.Models;
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
            var lstPeople = new List<Person>() {
                new Person(){Avatar = "https://randomuser.me/api/portraits/men/54.jpg", FirstName = "Jon", LastName="Coleman" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/men/50.jpg", FirstName = "Vernon", LastName="Walters" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/women/54.jpg", FirstName = "Beverley", LastName="Sutton" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/women/69.jpg", FirstName = "Scarlet", LastName="Kingsley" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/men/36.jpg", FirstName = "Everett", LastName="Riley" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/men/57.jpg", FirstName = "Lenny", LastName="Rodrigues" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/women/29.jpg", FirstName = "Addlynne", LastName="Fowler" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/women/44.jpg", FirstName = "Nicole", LastName="Jennings" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/men/11.jpg", FirstName = "Ole", LastName="Solksjaer" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/women/90.jpg", FirstName = "Avery", LastName="Burke" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/men/6.jpg", FirstName = "Lionel", LastName="Murphy" }
            };
            clVwPeople.ItemsSource = lstPeople;
        }
    }
}