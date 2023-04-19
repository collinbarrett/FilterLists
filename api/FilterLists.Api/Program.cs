using FilterLists.Api.EntityFrameworkCore;
using FilterLists.Api.EntityFrameworkCore.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .AddEntityFrameworkCore()
    .AddGraphQLFunction(b => b
        .AddTypes()
        .AddProjections()
        .RegisterDbContext<FilterListsDbContext>()
    )
    .Build();

host.Run();