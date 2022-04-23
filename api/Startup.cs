using System;
using FilterLists.Api;
using FilterLists.Api.FilterLists;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]

namespace FilterLists.Api;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddAzureClients(azClientBuilder =>
        {
            var connectionString = Environment.GetEnvironmentVariable("FilterListsStappApiStorage");
            azClientBuilder.AddTableServiceClient(connectionString);
        });
        builder.Services.AddScoped<IFilterListRepository, FilterListRepository>();
    }
}