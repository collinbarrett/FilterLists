using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;
using FilterLists.Agent.Core.Interfaces;
using FilterLists.Agent.Features.Urls.Models;
using FilterLists.Agent.Infrastructure.Clients;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.Repositories
{
    public class UrlsRepository : IUrlsRepository
    {
        private readonly IFilterListsApiClient _apiClient;

        public UrlsRepository(IFilterListsApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<IEnumerable<Uri>> GetAllAsync<TEntityUrls>() where TEntityUrls : IEntityUrls, new()
        {
            var endpoint = BuildEndpoint<TEntityUrls>();
            var request = new RestRequest(endpoint);
            var response = await _apiClient.ExecuteAsync<IEnumerable<TEntityUrls>>(request);
            return response.SelectMany(r => r.GetType().GetProperties().Select(p => (Uri)p.GetValue(r)))
                .Where(u => u != null);
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