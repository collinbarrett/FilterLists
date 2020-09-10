using FilterLists.Archival.Infrastructure.Options;
using LibGit2Sharp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    internal static class ServiceCollectionExtension
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<GitOptions>(configuration.GetSection(GitOptions.Key));
            services.AddTransient<IRepository, Repository>(_ =>
            {
                var gitOptions = new GitOptions();
                configuration.GetSection(GitOptions.Key).Bind(gitOptions);

                if (!Repository.IsValid(gitOptions.RepositoryDirectory))
                    Repository.Init(gitOptions.RepositoryDirectory);

                return new Repository(gitOptions.RepositoryDirectory);
            });
            services.AddTransient<IArchiveFile, GitFileArchiver>();
        }
    }
}