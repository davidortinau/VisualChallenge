using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public Movie Movie { get; set; }

        public IEnumerable<Movie> Related { get; set; }
        public IEnumerable<Person> Casting { get; set; }

        public VisualChallengePage()
        {
            Movie = new Movie
            {
                Backdrop = "http://image.tmdb.org/t/p/w780/xXGNyEG2v48q0bVR4AH4Vca2yvy.jpg",
                Poster = "http://image.tmdb.org/t/p/w342/5EJWZQ8dh99hfgXP9zAD5Ak5Hrn.jpg",
                Title = "A Simple Favor",
                Director = "Paul Feig",
                Released = new DateTime(2018, 08, 29).ToString("d MMM yyyy"),
                Genres = new string[] { "Thriller", "Crime", "Mystery", "Comedy", "Drama" },
                Runtime = "117 min",
                Certification = "R",
                Overview = $"Stephanie, a dedicated mother and popular vlogger, befriends Emily, a mysterious upper-class woman whose son Nicky attends the same school as Miles, Stephanie's son. When Emily asks her to pick Nicky up from school and then disappears, Stephanie undertakes an investigation that will dive deep into Emily's cloudy past.",
            };

            InitCasting();
            InitRelated();

            InitializeComponent();
            BindingContext = this;

            
        }

        private void InitRelated()
        {
            Related = new List<Movie>
            {
                new Movie {Title="The Revenant", Director="Alejandro Gonzalez", Poster="https://walter.trakt.tv/images/movies/000/179/334/posters/thumb/e1f48c2858.jpg"},
                new Movie {Title="The Hunger Games: Catching Fire", Director="Francis Lawrence", Poster="https://walter.trakt.tv/images/movies/000/072/719/posters/thumb/fc3ae9e451.jpg"},
                new Movie {Title="It", Director="Andy Muschietti", Poster="https://walter.trakt.tv/images/movies/000/242/226/posters/thumb/13da55fb0c.jpg"},
                new Movie {Title="Maze Runner: The Death Cure", Director="Wes Ball", Poster="https://walter.trakt.tv/images/movies/000/217/461/posters/thumb/7dfc16a0bc.jpg"},
                new Movie {Title="The Kissing Booth", Director="Vince Marcello", Poster="https://walter.trakt.tv/images/movies/000/346/591/posters/thumb/7401ff34f2.jpg"},
                new Movie {Title="A Walk Among The Tombstones", Director="Scott Frank", Poster="https://walter.trakt.tv/images/movies/000/108/370/posters/thumb/8caf17b49a.jpg"},
            };
        }

        private void InitCasting()
        {
            Casting = new List<Person>
            {
                new Person { ProfilePhoto="https://walter.trakt.tv/images/people/000/422/976/headshots/thumb/4ef945ff20.jpg", Character = "Stephanie Smothers", Name = "Anna Kendrick" },
                new Person { ProfilePhoto="https://walter.trakt.tv/images/people/000/419/376/headshots/thumb/943b0878c6.jpg", Character = "Emily Nelson", Name = "Blake Lively" },
                new Person { ProfilePhoto="https://walter.trakt.tv/images/people/000/874/059/headshots/thumb/43d97bacec.jpg", Character = "Sean Townsend", Name = "Henry golding" },
                new Person { ProfilePhoto="https://walter.trakt.tv/images/people/000/453/489/headshots/thumb/bc72255491.jpg", Character = "Darren", Name = "Andrew Rannells" },
                new Person { ProfilePhoto="https://walter.trakt.tv/images/people/000/419/216/headshots/thumb/d791118964.jpg", Character = "Dennis Nylon", Name = "Rupert Friend" },
                new Person { ProfilePhoto="https://walter.trakt.tv/images/people/001/267/273/headshots/thumb/c90bda8434.jpg", Character = "Nicky Nelson", Name = "Ian Ho" },
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));
        }
    }
}