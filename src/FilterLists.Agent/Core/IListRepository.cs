using System.Net.Http;

namespace FilterLists.Agent.Core
{
    public interface IListRepository
    {
        HttpClient HttpClient { get; }
    }
}