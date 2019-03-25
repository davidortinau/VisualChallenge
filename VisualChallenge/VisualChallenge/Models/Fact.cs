using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VisualChallenge.Models
{
    public class Fact
    {
        public string Id { get; set; }
        public IEnumerable<string> Category { get; set; }

        [JsonProperty(PropertyName = "icon_url")]
        public Uri IconUrl { get; set; }

        public Uri Url { get; set; }
        public string Value { get; set; }
    }
}
