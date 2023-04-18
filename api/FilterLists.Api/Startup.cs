using System;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure.Extensions;
using Microsoft.Azure.Functions.Worker.Extensions.OpenApi.Extensions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Api;

public class Program
{
    private static async Task Main(string[] args)
    {
        var host = new HostBuilder()
            .ConfigureFunctionsWorkerDefaults(worker => worker.UseNewtonsoftJson())
            .ConfigureServices(services =>
            {
                const string connectionStringKey = "FilterListsReadOnlyConnectionString";
                var readOnlyConnectionString = Environment.GetEnvironmentVariable(connectionStringKey) ??
                                               throw new InvalidOperationException($"Missing {connectionStringKey}");
                services.AddInfrastructure(readOnlyConnectionString);
                services.AddSingleton<IOpenApiConfigurationOptions>(_ => new OpenApiConfigurationOptions());
            })
            .Build();
        await host.RunAsync();
    }
}