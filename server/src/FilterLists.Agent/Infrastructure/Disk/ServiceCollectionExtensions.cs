using FilterLists.Agent.AppSettings;
using LibGit2Sharp;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent.Infrastructure.Disk
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDiskServices(this IServiceCollection services, ArchiveSettings archiveSettings)
        {
            services.AddTransient<IRepository, Repository>(s =>
            {
                if (!Repository.IsValid(archiveSettings.RepositoryDirectory))
                    Repository.Init(archiveSettings.RepositoryDirectory);
                return new Repository(archiveSettings.RepositoryDirectory);
            });
        }
    }
}