using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FilterLists.Agent.Infrastructure
{
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