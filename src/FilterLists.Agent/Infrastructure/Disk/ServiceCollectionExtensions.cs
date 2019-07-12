using FilterLists.Agent.AppSettings;
using LibGit2Sharp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace FilterLists.Agent.Infrastructure.Disk
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDiskResources(this IServiceCollection services)
        {
            services.AddTransient<IRepository, Repository>(s =>
            {
                var archiveSettings = s.GetService<IOptions<ArchiveSettings>>().Value;
                if (!Repository.IsValid(archiveSettings.RepositoryDirectory))
                    Repository.Init(archiveSettings.RepositoryDirectory);
                return new Repository(archiveSettings.RepositoryDirectory);
            });
        }
    }
}