using FilterLists.Archival.Infrastructure.Options;
using LibGit2Sharp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    public static class ServiceCollectionExtension
    {
        internal static void AddGitServices(this IServiceCollection services, IConfiguration configuration)
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
        }
    }
}