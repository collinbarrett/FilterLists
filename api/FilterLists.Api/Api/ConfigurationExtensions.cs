using FilterLists.Api.Persistence;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Api.Api;

internal static class ConfigurationExtensions
{
    internal static IHostBuilder AddGraphQl(this IHostBuilder hostBuilder)
    {
        // TODO: disable BCP telemetry https://chillicream.com/docs/hotchocolate/v13/server/endpoints#disabletelemetry
        return hostBuilder.AddGraphQLFunction(b => b
            .AddGraphQlTypes()
            .AddGlobalObjectIdentification()
            .AddProjections()
            .AddFiltering()
            .AddSorting()
            .RegisterDbContext<FilterListsDbContext>()
        );
    }
}