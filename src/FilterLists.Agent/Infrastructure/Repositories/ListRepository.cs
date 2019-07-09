using System;
using System.Net.Http;
using System.Net.Http.Headers;
using FilterLists.Agent.Core;
using JetBrains.Annotations;

namespace FilterLists.Agent.Infrastructure.Repositories
{
    [UsedImplicitly]
    public class ListRepository : IListRepository
    {
        public ListRepository(HttpClient client)
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