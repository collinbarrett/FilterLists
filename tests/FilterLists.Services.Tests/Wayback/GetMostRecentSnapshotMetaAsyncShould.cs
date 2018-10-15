using System;
using System.Net.Http;
using FilterLists.Services.Wayback;
using Xunit;

namespace FilterLists.Services.Tests.Wayback
{
    public class GetMostRecentSnapshotMetaAsyncShould
    {
        [Fact]
        public async void ReturnAccessibleUrlRawIfInWaybackMachine()
        {
            const string url = "https://github.com/collinbarrett/FilterLists";
            var meta = await WaybackService.GetMostRecentSnapshotMetaAsync(url);
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(meta.UrlRaw);
                Assert.True(response.IsSuccessStatusCode);
            }
        }

        [Fact]
        public async void ReturnNullIfUrlNotInWaybackMachine()
        {
            const string url = "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/doesnotexist";
            var meta = await WaybackService.GetMostRecentSnapshotMetaAsync(url);
            Assert.Null(meta);
        }

        [Fact]
        public async void ReturnRecentTimestampUtcIfInWaybackMachine()
        {
            const string url = "https://github.com/collinbarrett/FilterLists";
            var meta = await WaybackService.GetMostRecentSnapshotMetaAsync(url);
            Assert.True(meta.TimestampUtc > DateTime.Now.AddYears(-5).ToUniversalTime() &&
                        meta.TimestampUtc < DateTime.UtcNow);
        }
    }
}