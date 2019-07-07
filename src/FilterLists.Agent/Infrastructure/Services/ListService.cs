using System;
using System.Net.Http;
using System.Net.Http.Headers;
using FilterLists.Agent.Core.Interfaces.Services;
using JetBrains.Annotations;

namespace FilterLists.Agent.Infrastructure.Services
{
    [UsedImplicitly]
    public class ListService : IListService
    {
        public ListService(HttpClient client)
        {
            client.Timeout = TimeSpan.FromSeconds(90);

            var header = new ProductHeaderValue("FilterLists.Agent");
            var userAgent = new ProductInfoHeaderValue(header);
            client.DefaultRequestHeaders.UserAgent.Add(userAgent);

            HttpClient = client;
        }

        public HttpClient HttpClient { get; }
    }
}