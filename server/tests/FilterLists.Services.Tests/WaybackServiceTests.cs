using System;
using System.Net.Http;
using FilterLists.Services.Wayback;
using Xunit;

namespace FilterLists.Services.Tests
{
    public class WaybackServiceTests
    {
        [Fact(Skip = "https://github.com/collinbarrett/FilterLists/issues/590")]
        public async void GetMostRecentSnapshotMetaAsync_UrlInWaybackMachine_ReturnsAccessibleRawUrl()
        {
            const string url = "https://github.com/collinbarrett/FilterLists";
            var meta = await WaybackService.GetMostRecentSnapshotMetaAsync(url);
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(meta.RawUrl);
                Assert.True(response.IsSuccessStatusCode);
            }
        }

        [Fact(Skip = "https://github.com/collinbarrett/FilterLists/issues/590")]
        public async void GetMostRecentSnapshotMetaAsync_UrlInWaybackMachine_ReturnsRecentTimestampUtc()
        {
            const string url = "https://github.com/collinbarrett/FilterLists";
            var meta = await WaybackService.GetMostRecentSnapshotMetaAsync(url);
            Assert.True(meta.TimestampUtc > DateTime.Now.AddYears(-5).ToUniversalTime() &&
                        meta.TimestampUtc < DateTime.UtcNow);
        }

        [Fact(Skip = "https://github.com/collinbarrett/FilterLists/issues/590")]
        public async void GetMostRecentSnapshotMetaAsync_UrlNotInWaybackMachine_ReturnsNull()
        {
            const string url = "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/doesnotexist";
            var meta = await WaybackService.GetMostRecentSnapshotMetaAsync(url);
            Assert.Null(meta);
        }
    }
}