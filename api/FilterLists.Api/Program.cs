using FilterLists.Api.Api;
using FilterLists.Api.Persistence.Extensions;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .AddEntityFrameworkCore()
    .AddGraphQl()
    .Build();

host.Run();