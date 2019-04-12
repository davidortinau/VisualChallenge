using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Refit;

namespace VisualChallenge.Services
{
    public interface IWykopApi
    {
        [Get("/links/promoted/")]
        Task<List<Link>> GetLinks();
    }

    [DataContract]
    public class Link
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }
        
        [DataMember(Name = "vote_count")]
        public int VoteCount { get; set; }
        
        [DataMember(Name = "preview")]
        public string ImageUrl { get; set; }
    }

    public class AuthenticatedHttpClientHandler : HttpClientHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            request.RequestUri = new Uri(request.RequestUri.ToString() + "appkey,[ENTER_YOUR_API_KEY]");

            return base.SendAsync(request, cancellationToken);
        }

    }
}