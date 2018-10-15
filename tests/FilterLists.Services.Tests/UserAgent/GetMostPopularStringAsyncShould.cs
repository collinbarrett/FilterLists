using Xunit;

namespace FilterLists.Services.Tests.UserAgent
{
    public class GetMostPopularStringAsyncShould
    {
        [Fact]
        public async void ReturnStringContainingMozilla()
        {
            var actualString = await UserAgentService.GetMostPopularStringAsync();
            Assert.Contains("Mozilla", actualString);
        }
    }
}