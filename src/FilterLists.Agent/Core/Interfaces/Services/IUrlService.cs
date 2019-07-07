using System.Net.Http;

namespace FilterLists.Agent.Core.Interfaces.Services
{
    public interface IUrlService
    {
        HttpClient HttpClient { get; }
    }
}