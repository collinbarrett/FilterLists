using System.Threading;
using System.Threading.Tasks;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.FilterListsApi
{
    public interface IFilterListsApiClient
    {
        Task<TResponse> ExecuteAsync<TResponse>(IRestRequest restRequest, CancellationToken cancellationToken);
    }
}