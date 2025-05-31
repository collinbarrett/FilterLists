using FilterLists.Directory.Infrastructure;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Directory.Application;

public static class ConfigurationExtensions
{
    public static void AddApplication(this IHostApplicationBuilder builder)
    {
        builder.AddInfrastructure();
    }
}