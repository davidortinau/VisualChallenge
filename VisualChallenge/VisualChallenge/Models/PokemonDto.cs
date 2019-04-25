using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace VisualChallenge.Models
{
    public class PokemonDto
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        [JsonProperty(PropertyName = "results")]
        public List<PokemonDetalleDto> PokemonDetalleDto { get; set; }

    }
    public class PokemonDetalleDto
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
