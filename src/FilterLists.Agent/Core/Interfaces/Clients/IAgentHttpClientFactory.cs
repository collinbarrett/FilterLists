using System.Net.Http;

namespace FilterLists.Agent.Core.Interfaces.Clients
{
    public interface IAgentHttpClientFactory
    {
        HttpClient HttpClient { get; }
    }
}