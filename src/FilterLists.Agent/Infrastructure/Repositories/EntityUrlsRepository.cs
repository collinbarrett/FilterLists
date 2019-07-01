using System.Collections.Generic;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;
using FilterLists.Agent.Core.Interfaces;
using FilterLists.Agent.Infrastructure.Clients;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.Repositories
{
    public class EntityUrlsRepository : IEntityUrlsRepository
    {
        private readonly IFilterListsApiClient _apiClient;

        public EntityUrlsRepository(IFilterListsApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<IEnumerable<TEntityUrls>> GetAllAsync<TEntityUrls>() where TEntityUrls : IEntityUrls, new()
        {
            var endpoint = BuildEndpoint<TEntityUrls>();
            var request = new RestRequest(endpoint);
            return await _apiClient.ExecuteAsync<IEnumerable<TEntityUrls>>(request);
        }

        private static string BuildEndpoint<TEntityUrls>() where TEntityUrls : IEntityUrls, new()
        {
            string endpointSuffix;
            switch (typeof(TEntityUrls).Name)
            {
                case nameof(SyntaxUrls):
                    endpointSuffix = "es";
                    break;
                case nameof(SoftwareUrls):
                    endpointSuffix = "";
                    break;
                default:
                    endpointSuffix = "s";
                    break;
            }

            return $"{typeof(TEntityUrls).Name.Replace("Urls", endpointSuffix).ToLowerInvariant()}/seed";
        }
    }
}