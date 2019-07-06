using System;
using System.Collections.Generic;
using FilterLists.Agent.Extensions;
using Xunit;

namespace FilterLists.Agent.Tests.Extensions
{
    public class UriExtensionsTests
    {
        [Fact]
        public void GetExtension_UriWithoutExtension_ReturnsEmptyString()
        {
            var uri = new Uri("https://www.google.com/");
            var sut = uri.GetExtension();
            Assert.Equal("", sut);
        }

        [Fact]
        public void GetExtension_UriWithExtension_ReturnsExtension()
        {
            var uri = new Uri("https://www.google.com/robots.txt");
            var sut = uri.GetExtension();
            Assert.Equal(".txt", sut);
        }

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