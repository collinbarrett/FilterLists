using System;
using System.Net.Http;
using System.Threading.Tasks;
using FilterLists.Services.Extensions;
using FilterLists.Services.Wayback.Models;
using Newtonsoft.Json;

namespace FilterLists.Services.Wayback
{
    public static class WaybackService
    {
        private const string WaybackAvailabilityApiUrlPrefix = "https://archive.org/wayback/available?url=";

        public static async Task<SnapshotMetaDto> GetMostRecentSnapshotMeta(string url)
        {
            var closest = (await GetWaybackAvailability(url))?.ArchivedSnapshots?.Closest;
            return closest != null
                ? new SnapshotMetaDto {TimestampUtc = ParseTimestampUtc(closest), UrlRaw = ParseUrlRaw(closest)}
                : null;
        }

        private static async Task<Availability> GetWaybackAvailability(string url)
        {
            using (var client = new HttpClient())
            {
                var fullUrl = WaybackAvailabilityApiUrlPrefix + url;
                var response = await client.GetAsync(fullUrl, HttpCompletionOption.ResponseHeadersRead);
                var jsonString = await response.Content.ReadAsStringAsync();
                try
                {
                    return JsonConvert.DeserializeObject<Availability>(jsonString);
                }
                catch (JsonReaderException)
                {
                    return null;
                }
            }
        }

        private static string ParseUrlRaw(Closest closest)
        {
            var waybackUrl = closest.Url;
            var indexOfUrlModification = waybackUrl.GetNthIndexOfChar(5, '/');
            const string urlModification = "if_";
            return waybackUrl.Substring(0, indexOfUrlModification) + urlModification +
                   waybackUrl.Substring(indexOfUrlModification);
        }

        private static DateTime ParseTimestampUtc(Closest closest) =>
            DateTimeOffset.ParseExact(closest.Timestamp, "yyyyMMddHHmmss", null).UtcDateTime;
    }
}