using Xunit;

namespace FilterLists.Services.Tests
{
    public class UserAgentServiceTests
    {
        [Fact]
        public async void GetMostPopularStringAsync_ReturnsStringContainingMozilla()
        {
            var actualString = await UserAgentService.GetMostPopularStringAsync();
            Assert.Contains("Mozilla", actualString);
        }
    }
}