using System;
using FilterLists.Api;
using FilterLists.Api.Infrastructure.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

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
        builder.Services.AddSingleton<IOpenApiConfigurationOptions>(_ => new OpenApiConfigurationOptions
        {
            Info = new OpenApiInfo
            {
                Title = "FilterLists API",
                Description = "A RESTful API serving the FilterLists information.",
                Version = "v1",
                TermsOfService = null,
                Contact = new OpenApiContact
                {
                    Name = "FilterLists",
                    Url = new Uri("https://filterlists.com")
                },
                License = new OpenApiLicense
                {
                    Name = "MIT License",
                    Url = new Uri("https://github.com/collinbarrett/FilterLists/blob/main/LICENSE")
                }
            },
            OpenApiVersion = OpenApiVersionType.V3
        });
    }
}