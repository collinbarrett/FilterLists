using System;
using FilterLists.Api;
using FilterLists.Api.Infrastructure.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]

namespace FilterLists.Api;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        const string connectionStringKey = "FilterListsReadOnlyConnectionString";
        var readOnlyConnectionString = Environment.GetEnvironmentVariable(connectionStringKey) ??
                                       throw new InvalidOperationException($"Missing {connectionStringKey}");
        builder.Services.AddInfrastructure(readOnlyConnectionString);
        builder.Services.AddSingleton<IOpenApiConfigurationOptions>(
            _ => new FilterListsApiOpenApiConfigurationOptions());
    }
}