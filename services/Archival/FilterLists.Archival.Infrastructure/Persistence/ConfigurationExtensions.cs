using FilterLists.Archival.Domain.ListArchives;
using FilterLists.Archival.Infrastructure.Options;
using LibGit2Sharp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Archival.Infrastructure.Persistence;

internal static class ConfigurationExtensions
{
    public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<GitOptions>(configuration.GetSection(GitOptions.Key));
        services.AddTransient<IRepository, Repository>(_ =>
        {
            var gitOptions = configuration.GetSection(GitOptions.Key).Get<GitOptions>();
            if (!Repository.IsValid(gitOptions.RepositoryPath))
            {
                Repository.Init(gitOptions.RepositoryPath);
            }

            return new Repository(gitOptions.RepositoryPath);
        });
        services.AddTransient<IListArchiveRepository, GitListArchiveRepository>();
    }
}
