using FilterLists.Services.Extensions;
using Xunit;

namespace FilterLists.Services.Tests.Extensions.String
{
    public class IsValidHttpOrHttpsUrlShould
    {
        [Theory]
        [InlineData("abp://www.google.com")]
        [InlineData("www.google.com")]
        [InlineData("google")]
        public void ReturnFalseIfNotHttpOrHttps(string url)
        {
            Assert.False(url.IsValidHttpOrHttpsUrl());
        }

        [Fact]
        public void ReturnTrueIfValidHttpsUrl()
        {
            const string httpsUrl = "https://www.google.com";
            Assert.True(httpsUrl.IsValidHttpOrHttpsUrl());
        }

        [Fact]
        public void ReturnTrueIfValidHttpUrl()
        {
            const string httpUrl = "http://www.google.com";
            Assert.True(httpUrl.IsValidHttpOrHttpsUrl());
        }
    }
}