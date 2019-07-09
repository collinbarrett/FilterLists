using System.Net.Http;

namespace FilterLists.Agent.Core.List
{
    public interface IListRepository
    {
        //TODO: expose GetList() method rather than HttpClient
        HttpClient HttpClient { get; }
    }
}