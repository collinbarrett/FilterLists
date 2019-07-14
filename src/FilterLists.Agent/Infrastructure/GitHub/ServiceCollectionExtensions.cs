using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Core.GitHub;
using Microsoft.Extensions.DependencyInjection;
using Octokit;

namespace FilterLists.Agent.Infrastructure.GitHub
{
    public static class ServiceCollectionExtensions
    {
        public static void AddGitHubServices(this IServiceCollection services, GitHubSettings gitHubSettings)
        {
            services.AddSingleton<IGitHubClient, GitHubClient>(s =>
                new GitHubClient(new ProductHeaderValue(gitHubSettings.ProductHeaderValue))
                    {Credentials = new Credentials(gitHubSettings.PersonalAccessToken)});
            services.AddTransient<IIssuesRepository, IssuesRepository>();
        }
    }
}