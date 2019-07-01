using System.Collections.Generic;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;
using FilterLists.Agent.Core.Interfaces;
using FilterLists.Agent.Infrastructure.Clients;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.Repositories
{
    public class ListInfoRepository : IListInfoRepository
    {
        private readonly IFilterListsApiClient _apiClient;

        public ListInfoRepository(IFilterListsApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<IEnumerable<ListInfo>> GetAllAsync()
        {
            var listsRequest = new RestRequest("lists");
            return await _apiClient.ExecuteAsync<IEnumerable<ListInfo>>(listsRequest);
        }
    }
}