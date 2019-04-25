using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VisualChallenge.Services
{
    public interface IPokemonServices
    {
        [Get("/pokemon-form/?limit=151&offset=0")]
        Task<HttpResponseMessage> GetListPokemon();
    }
}
