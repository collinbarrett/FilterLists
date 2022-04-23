using System;
using FilterLists.Seed;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Azure;

[assembly: FunctionsStartup(typeof(Startup))]

namespace FilterLists.Seed;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddAzureClients(azClientBuilder =>
        {
            var connectionString = Environment.GetEnvironmentVariable("FilterListsStappApiStorage");
            azClientBuilder.AddTableServiceClient(connectionString);
        });
    }
}