using Swashbuckle.AspNetCore.SwaggerUI;

namespace FilterLists.Directory.Api.OpenApi;

internal static class SwaggerUiConfiguration
{
    internal static readonly Action<SwaggerUIOptions> SetupAction = options =>
    {
        options.DocumentTitle = "FilterLists API";
        options.SwaggerEndpoint("/v1/openapi.json", "FilterLists Directory API v1");
        options.RoutePrefix = string.Empty;
    };
}