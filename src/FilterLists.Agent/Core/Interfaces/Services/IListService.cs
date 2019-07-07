using System.Net.Http;

namespace FilterLists.Agent.Core.Interfaces.Services
{
    public interface IListService
    {
        HttpClient HttpClient { get; }
    }
}