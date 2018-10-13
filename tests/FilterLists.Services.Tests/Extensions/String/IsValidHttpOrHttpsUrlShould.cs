using FilterLists.Services.Extensions;
using Xunit;

namespace FilterLists.Services.Tests.Extensions.String
{
    public class IsValidHttpOrHttpsUrlShould
    {
        [Fact]
        public void ReturnFalseIfNotHttpOrHttps()
        {
            const string abp = "abp://www.google.com";
            Assert.False(abp.IsValidHttpOrHttpsUrl());
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