using System.Net;
using Projects;

namespace FilterLists.Tests;

public sealed class DirectoryApiTests
{
    [Fact]
    public async Task GetDirectoryApiAliveReturnsOkStatusCode()
    {
        // Arrange
        var appHost = await DistributedApplicationTestingBuilder.CreateAsync<FilterLists_AppHost>();
        await using var app = await appHost.BuildAsync();
        await app.StartAsync();

        // Act
        var httpClient = app.CreateHttpClient("directoryapi");
        var response = await httpClient.GetAsync("/alive");

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}