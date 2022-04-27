using System;
using FilterLists.Api;
using FilterLists.Api.Persistence;
using MediatR;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Azure;

[assembly: FunctionsStartup(typeof(Startup))]

namespace FilterLists.Api;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddAzureClients(azClientBuilder =>
        {
            var connectionString = Environment.GetEnvironmentVariable(TableStorageConstants.ConnectionStringConfigKey);
            azClientBuilder.AddTableServiceClient(connectionString);
        });
        builder.Services.AddMediatR(typeof(Startup));
    }
}