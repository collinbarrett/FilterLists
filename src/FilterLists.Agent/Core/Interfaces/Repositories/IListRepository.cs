using System.Net.Http;

namespace FilterLists.Agent.Core.Interfaces.Repositories
{
    public interface IListRepository
    {
        HttpClient HttpClient { get; }
    }
}