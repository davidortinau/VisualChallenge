using System.Collections.Generic;

namespace VisualChallenge.Models
{
    public class FactSearchResult
    {
        public int Total { get; set; }
        public IEnumerable<Fact> Result { get; set; }
    }
}
