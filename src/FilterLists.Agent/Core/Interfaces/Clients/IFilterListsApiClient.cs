using System.Threading.Tasks;
using RestSharp;

namespace FilterLists.Agent.Core.Interfaces.Clients
{
    public interface IFilterListsApiClient
    {
        Task<TResponse> ExecuteAsync<TResponse>(IRestRequest request);
    }
}