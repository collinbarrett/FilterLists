using FilterLists.Api.Persistence;
using FilterLists.Api.Persistence.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .AddEntityFrameworkCore()
    .AddGraphQLFunction(b => b
        .AddGraphQLTypes()
        .AddProjections()
        .RegisterDbContext<FilterListsDbContext>()
    )
    .Build();

host.Run();