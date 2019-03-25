using System;
using System.Collections.Generic;
using System.Text;

namespace VisualChallenge
{
    public class Movie
    {
        public string Poster { get; set; }
        public string Backdrop { get; set; }
        public string Director { get; set; }
        public string Title { get; set; }
        public string Runtime { get; set; }
        public string Certification { get; set; }
        public string Released { get; set; }
        public string Overview { get; set; }
        public IEnumerable<string> Genres { get; set; }
        
    }
}
