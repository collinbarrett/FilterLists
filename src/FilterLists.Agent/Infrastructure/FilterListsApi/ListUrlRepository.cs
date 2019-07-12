using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Lists;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.FilterListsApi
{
    public class ListUrlRepository : IListUrlRepository
    {
        private readonly IFilterListsApiClient _apiClient;

        public ListUrlRepository(IFilterListsApiClient filterListsApiClient)
        {
            _apiClient = filterListsApiClient;
        }

        public async Task<IEnumerable<ListUrl>> GetAllAsync(CancellationToken cancellationToken)
        {
            var listsRequest = new RestRequest("lists");
            return await _apiClient.ExecuteAsync<IEnumerable<ListUrl>>(listsRequest, cancellationToken);
        }
    }
}