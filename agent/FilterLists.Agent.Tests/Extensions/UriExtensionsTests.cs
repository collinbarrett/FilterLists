using System;
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
    }
}