using FilterLists.Api;
using FilterLists.Api.FilterLists;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]

namespace FilterLists.Api;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        var configuration = builder.GetContext().Configuration;
        builder.Services.AddAzureClients(azureClientFactoryBuilder =>
        {
            var connectionString = configuration.GetConnectionString("FilterListsApiStorage");
            azureClientFactoryBuilder.AddTableServiceClient(connectionString);
        });
        builder.Services.AddScoped<IFilterListRepository, FilterListRepository>();
    }
}