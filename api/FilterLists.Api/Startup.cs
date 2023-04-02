using System;
using System.ComponentModel;
using FilterLists.Api;
using FilterLists.Api.Queries.Context;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]

namespace FilterLists.Api;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddDbContext<QueryDbContext>(options =>
            options.UseSqlServer(Environment.GetEnvironmentVariable("FilterListsReadOnlyConnectionString") ??
                                 throw new InvalidEnumArgumentException(
                                     "missing FilterListsReadOnlyConnectionString")));
        builder.Services.AddScoped<IQueryContext, QueryContext>();
    }
}