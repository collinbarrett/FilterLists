using System;
using System.Net.Http;
using System.Net.Http.Headers;
using JetBrains.Annotations;

namespace FilterLists.Agent.Infrastructure.Clients
{
    [UsedImplicitly]
    public class AgentHttpClient
    {
        public AgentHttpClient(HttpClient client)
        {
            client.Timeout = TimeSpan.FromMinutes(10);

            var header = new ProductHeaderValue("FilterLists.Agent");
            var userAgent = new ProductInfoHeaderValue(header);
            client.DefaultRequestHeaders.UserAgent.Add(userAgent);

            Client = client;
        }

        public HttpClient Client { get; }
    }
}