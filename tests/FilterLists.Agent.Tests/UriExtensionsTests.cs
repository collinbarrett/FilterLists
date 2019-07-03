using System;
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
    }
}