using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using VisualChallenge.Models;

namespace VisualChallenge.Services
{
    public interface IChuckNorrisFactService
    {
        [Get("/jokes/random?category={category}")]
        Task<Fact> GetRandomFact(string category);

        [Get("/jokes/categories")]
        Task<IList<string>> GetCategories();

        [Get("/jokes/search?query={query}")]
        Task<FactSearchResult> Search(string query);
    }
}
