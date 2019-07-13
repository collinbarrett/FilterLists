using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Urls;
using FilterLists.Agent.Features.Urls.Models;
using JetBrains.Annotations;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.FilterListsApi
{
    [UsedImplicitly]
    public class EntityUrlRepository : IEntityUrlRepository
    {
        private static readonly Dictionary<string, (string, FilterListsEntity)> EndpointAndEntityByDto =
            new Dictionary<string, (string, FilterListsEntity)>
            {
                {nameof(LicenseUrls), ("licenses", FilterListsEntity.License)},
                {nameof(ListUrls), ("lists", FilterListsEntity.FilterList)},
                {nameof(MaintainerUrls), ("maintainers", FilterListsEntity.Maintainer)},
                {nameof(SoftwareUrls), ("software", FilterListsEntity.Software)},
                {nameof(SyntaxUrls), ("syntaxes", FilterListsEntity.Syntax)}
            };

        private readonly IFilterListsApiClient _apiClient;

        public EntityUrlRepository(IFilterListsApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<IEnumerable<EntityUrl>> GetAllAsync(CancellationToken cancellationToken)
        {
            return (await Task.WhenAll(
                    Task.Run(() => GetAllForEntity<LicenseUrls>(cancellationToken), cancellationToken),
                    Task.Run(() => GetAllForEntity<ListUrls>(cancellationToken), cancellationToken),
                    Task.Run(() => GetAllForEntity<MaintainerUrls>(cancellationToken), cancellationToken),
                    Task.Run(() => GetAllForEntity<SoftwareUrls>(cancellationToken), cancellationToken),
                    Task.Run(() => GetAllForEntity<SyntaxUrls>(cancellationToken), cancellationToken)))
                .SelectMany(r => r);
        }

        private async Task<IEnumerable<EntityUrl>> GetAllForEntity<TModel>(CancellationToken cancellationToken)
        {
            var request = new RestRequest($"{EndpointAndEntityByDto[typeof(TModel).Name].Item1}/seed");
            var response = await _apiClient.ExecuteAsync<IEnumerable<TModel>>(request, cancellationToken);
            return response.SelectMany(e =>
            {
                var propertyInfos = e.GetType().GetProperties();
                var id = (int)propertyInfos.First(p => p.Name == nameof(LicenseUrls.Id)).GetValue(e);
                return propertyInfos.Where(p => p.GetValue(e) != null && p.PropertyType == typeof(Uri)).Select(p =>
                    new EntityUrl(EndpointAndEntityByDto[typeof(TModel).Name].Item2, id, (Uri)p.GetValue(e)));
            }).GroupBy(e => e.ViewUrl).Select(e => e.First());
        }
    }
}