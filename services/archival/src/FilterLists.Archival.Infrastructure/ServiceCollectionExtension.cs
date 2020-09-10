using System;
using FilterLists.Archival.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Archival.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            _ = configuration ?? throw new ArgumentNullException(nameof(configuration));

            services.AddGitServices(configuration);
            services.AddTransient<IArchiveFile, GitFileArchiver>();
        }
    }
}