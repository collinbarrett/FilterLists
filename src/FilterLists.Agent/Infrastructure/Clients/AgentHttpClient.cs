using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FilterLists.Agent.Infrastructure.Clients
{
    public interface IAgentHttpClient
    {
        HttpClient HttpClient { get; }
    }

    public class AgentHttpClient : IAgentHttpClient
    {
        public AgentHttpClient(HttpClient client)
        {
            client.Timeout = TimeSpan.FromMinutes(10);

            var header = new ProductHeaderValue("FilterLists.Agent");
            var userAgent = new ProductInfoHeaderValue(header);
            client.DefaultRequestHeaders.UserAgent.Add(userAgent);

            HttpClient = client;
        }

        public HttpClient HttpClient { get; }
    }
}