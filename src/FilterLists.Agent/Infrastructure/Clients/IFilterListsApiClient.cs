using System.Threading.Tasks;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.Clients
{
    public interface IFilterListsApiClient
    {
        Task<TResponse> ExecuteAsync<TResponse>(IRestRequest request);
    }
}