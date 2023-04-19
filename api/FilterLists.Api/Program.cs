using FilterLists.Api;
using FilterLists.Api.Infrastructure.Context;
using FilterLists.Api.Infrastructure.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        const string connectionStringKey = "FilterListsReadOnlyConnectionString";
        var readOnlyConnectionString = Environment.GetEnvironmentVariable(connectionStringKey) ??
                                       throw new InvalidOperationException($"Missing {connectionStringKey}");
        services.AddInfrastructure(readOnlyConnectionString);
    })
    .AddGraphQLFunction(b => b.AddProjections().RegisterDbContext<FilterListsDbContext>().AddQueryType<Query>())
    .Build();

host.Run();