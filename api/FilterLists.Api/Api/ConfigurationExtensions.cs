using FilterLists.Api.Persistence;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Api.Api;

public static class ConfigurationExtensions
{
    public static IHostBuilder AddGraphQl(this IHostBuilder hostBuilder)
    {
        return hostBuilder.AddGraphQLFunction(b => b
            .AddGraphQlTypes()
            .AddGlobalObjectIdentification()
            .AddProjections()
            .RegisterDbContext<FilterListsDbContext>()
        );
    }
}