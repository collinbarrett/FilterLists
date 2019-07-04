using System;
using System.Net.Http;
using System.Net.Http.Headers;
using JetBrains.Annotations;

namespace FilterLists.Agent.Infrastructure.Clients
{
    public interface IAgentHttpClient
    {
        HttpClient HttpClient { get; }
    }

    [UsedImplicitly]
    public class AgentHttpClient : IAgentHttpClient
    {
        public AgentHttpClient(HttpClient client)
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