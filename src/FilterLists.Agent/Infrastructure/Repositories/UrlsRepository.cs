using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Uri>> GetAllAsync<TModel>()
        {
            var endpoint = BuildEndpoint<TModel>();
            var request = new RestRequest(endpoint);
            var response = await _apiClient.ExecuteAsync<IEnumerable<TModel>>(request);
            return response.SelectMany(r =>
                    r.GetType().GetProperties().Where(p => p.GetType() == typeof(Uri)).Select(p => (Uri)p.GetValue(r)))
                .Where(u => u != null);
        }

        private static string BuildEndpoint<TModel>()
        {
            string endpointSuffix;
            switch (typeof(TModel).Name)
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

            return $"{typeof(TModel).Name.Replace("Urls", endpointSuffix).ToLowerInvariant()}/seed";
        }
    }
}