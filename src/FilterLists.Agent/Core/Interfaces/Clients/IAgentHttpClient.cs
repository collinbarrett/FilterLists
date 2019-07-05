using System.Net.Http;

namespace FilterLists.Agent.Core.Interfaces.Clients
{
    public interface IAgentHttpClient
    {
        HttpClient HttpClient { get; }
    }
}