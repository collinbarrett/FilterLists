using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Urls;
using FilterLists.Agent.Infrastructure.FilterListsApi.EntityUrls;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.FilterListsApi
{
    public class EntityUrlRepository : IEntityUrlRepository
    {
        private static readonly Dictionary<string, (string, Entity)> EndpointAndEntityByDto =
            new Dictionary<string, (string, Entity)>
            {
                {nameof(LicenseUrls), ("licenses", Entity.License)},
                {nameof(ListUrls), ("lists", Entity.FilterList)},
                {nameof(MaintainerUrls), ("maintainers", Entity.Maintainer)},
                {nameof(SoftwareUrls), ("software", Entity.Software)},
                {nameof(SyntaxUrls), ("syntaxes", Entity.Syntax)}
            };

        private readonly IFilterListsApiClient _apiClient;

        public EntityUrlRepository(IFilterListsApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<IEnumerable<EntityUrl>> GetAllAsync(CancellationToken cancellationToken)
        {
            return (await Task.WhenAll(
                    Task.Run(() => GetDistinctForEntity<LicenseUrls>(cancellationToken), cancellationToken),
                    Task.Run(() => GetDistinctForEntity<ListUrls>(cancellationToken), cancellationToken),
                    Task.Run(() => GetDistinctForEntity<MaintainerUrls>(cancellationToken), cancellationToken),
                    Task.Run(() => GetDistinctForEntity<SoftwareUrls>(cancellationToken), cancellationToken),
                    Task.Run(() => GetDistinctForEntity<SyntaxUrls>(cancellationToken), cancellationToken)))
                .SelectMany(r => r);
        }

        private async Task<IEnumerable<EntityUrl>> GetDistinctForEntity<TModel>(CancellationToken cancellationToken)
        {
            var request = new RestRequest($"{EndpointAndEntityByDto[typeof(TModel).Name].Item1}/seed");
            var response = await _apiClient.ExecuteAsync<IEnumerable<TModel>>(request, cancellationToken);
            return response.SelectMany(e =>
            {
                var propertyInfos = e.GetType().GetProperties();
                var id = (int)propertyInfos.First(p => p.Name == nameof(LicenseUrls.Id)).GetValue(e);
                return propertyInfos.Where(p => p.GetValue(e) != null && p.PropertyType == typeof(Uri)).Select(p =>
                    new EntityUrl(EndpointAndEntityByDto[typeof(TModel).Name].Item2, id, (Uri)p.GetValue(e)));
            }).GroupBy(e => e.Url).Select(e => e.First());
        }
    }
}