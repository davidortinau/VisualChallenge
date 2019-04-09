using System;
using System.Collections.Generic;
using System.Text;

namespace VisualChallenge
{
    public class BlogItem
    {
        public BlogItem(int num)
        {
            ImageUrl = "https://cpwebsite-prod.azureedge.net/-/media/Project/Clearpeople/Images/Digital/EssentialsMAX-jpg.jpg";
            AuthorName = string.Format("Author nº{0}", num);
            Title = string.Format("Title nº{0}", num);
            AuthorImageUrl = "https://cpwebsite-prod.azureedge.net/-/media/Project/Clearpeople/Images/Staff-Photos/Jorge-jpg.jpg";
            Date = string.Format("{0} MAR 2019", num);
        }

        public string ImageUrl { get; set; }
        public string AuthorImageUrl { get; set; }
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
    }
}
