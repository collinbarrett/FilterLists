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

        public async Task<IEnumerable<TEntityUrls>> GetAllAsync<TEntityUrls>()
            where TEntityUrls : IEntityUrls, new()
        {
            string entityEndpoint;
            switch (typeof(TEntityUrls).Name)
            {
                case nameof(SyntaxUrls):
                    entityEndpoint = typeof(TEntityUrls).Name.Replace("Urls", "es").ToLowerInvariant();
                    break;
                case nameof(SoftwareUrls):
                    entityEndpoint = typeof(TEntityUrls).Name.Replace("Urls", "").ToLowerInvariant();
                    break;
                default:
                    entityEndpoint = typeof(TEntityUrls).Name.Replace("Urls", "s").ToLowerInvariant();
                    break;
            }

            var endpoint = $"{entityEndpoint}/seed";
            var request = new RestRequest(endpoint);
            return await _apiClient.ExecuteAsync<IEnumerable<TEntityUrls>>(request);
        }
    }
}