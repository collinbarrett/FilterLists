using System;
using System.Collections.Generic;
using FilterLists.Agent.Extensions;
using Xunit;

namespace FilterLists.Agent.Tests
{
    public class UriExtensionsTests
    {
        [Fact]
        public void IsValidUrl_WithValidUrl_ReturnsTrue()
        {
            const string uriString = "https://www.google.com/";
            var uri = new Uri(uriString);
            var sut = uri.IsValidUrl();
            Assert.True(sut);
        }

        [Fact]
        public void DistributeByHost_HasOverweightHost_DistributesEvenly()
        {
            var uris = new List<Uri>
            {
                new Uri("https://www.google.com/"),
                new Uri("https://www.google.com/"),
                new Uri("https://www.google.com/"),
                new Uri("https://www.facebook.com/"),
                new Uri("https://www.facebook.com/")
            };

            var sut = uris.DistributeByHost();

            var expected = new List<Uri>
            {
                new Uri("https://www.google.com/"),
                new Uri("https://www.facebook.com/"),
                new Uri("https://www.google.com/"),
                new Uri("https://www.facebook.com/"),
                new Uri("https://www.google.com/")
            };

            Assert.Equal(expected, sut);
        }
    }
}