using System;
using System.Collections.Generic;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.OpenApi.Models;

namespace FilterLists.Api;

internal class FilterListsApiOpenApiConfigurationOptions : DefaultOpenApiConfigurationOptions
{
    public override OpenApiInfo Info { get; set; } = new()
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
    };

    public override OpenApiVersionType OpenApiVersion { get; set; } = OpenApiVersionType.V3;
}