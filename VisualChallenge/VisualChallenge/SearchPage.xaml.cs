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

            var lstEvents = new List<Event>()
            {
                new Event(){ Destination = "New York", Airplane="Delta Air Lines", AirplaneCode = "", DepartureAirport = "SFO", ArrivalAirport = "JFK", DepartureTime = new DateTime(2019,1,15,5,35,0), ArrivalTime = new DateTime(2019,1,16,4,40,0) },
                new Event(){ Destination = "Paris", Airplane="Contoso Airlines", AirplaneCode = "AA 1234", DepartureAirport = "JFK", ArrivalAirport = "CDG", DepartureTime = new DateTime(2019,1,18,7,0,0), ArrivalTime = new DateTime(2019,1,19,6,0,0) }
            };
            clVwUpcoming.ItemsSource = lstEvents;

            var lstFiles = new List<File>()
            {
                new File(){ FileName="Resume",FileExt="PDF",FileIcon="pdf.png"},
                new File(){ FileName="Work_report",FileExt="XSLX",FileIcon="excel.png"},
                new File(){ FileName="Receipt",FileExt="DOCX",FileIcon="word.png"}
            };
            clVwFiles.ItemsSource = lstFiles;
        }
    }
}