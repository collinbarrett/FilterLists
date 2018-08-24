using System;
using System.Net.Http;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Services.Extensions;
using FilterLists.Services.Snapshot.Models;
using FilterLists.Services.Snapshot.Models.Wayback;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FilterLists.Services.Snapshot
{
    public class SnapshotWayback : Snapshot
    {
        private const string WaybackAvailabilityApiUrlPrefix = "https://archive.org/wayback/available?url=";

        public SnapshotWayback()
        {
        }

        [UsedImplicitly]
        public SnapshotWayback(FilterListsDbContext dbContext, FilterListViewUrlDto list, string uaString)
            : base(dbContext, list, uaString)
        {
        }

        public override async Task TrySaveAsync()
        {
            await UpdateWaybackData();
            await TrySaveAsyncBase();
        }

        private async Task UpdateWaybackData()
        {
            var availability = await GetWaybackAvailability();
            var closest = availability.ArchivedSnapshots?.Closest;
            if (closest != null)
            {
                UpdateViewUrl(closest);
                UpdateTimestamp(closest);
            }
            else
            {
                ListUrl = null;
            }
        }

        private async Task<Availability> GetWaybackAvailability()
        {
            using (var client = new HttpClient())
            {
                var url = WaybackAvailabilityApiUrlPrefix + ListUrl;
                var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Availability>(jsonString);
            }
        }

        private void UpdateViewUrl(Closest closest)
        {
            var waybackUrl = closest.Url;
            var indexOfUrlModification = waybackUrl.GetNthIndexOfChar(5, '/');
            const string urlModification = "if_";
            ListUrl = waybackUrl.Substring(0, indexOfUrlModification) + urlModification +
                      waybackUrl.Substring(indexOfUrlModification);
        }

        private void UpdateTimestamp(Closest closest) =>
            SnapEntity.WaybackTimestamp =
                DateTimeOffset.ParseExact(closest.Timestamp, "yyyyMMddHHmmss", null).UtcDateTime;
    }
}