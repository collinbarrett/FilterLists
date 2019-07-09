using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Core.GitHub;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Octokit;

namespace FilterLists.Agent.Infrastructure.GitHub
{
    public static class ServiceCollectionExtensions
    {
        public static void AddGitHubResources(this IServiceCollection services)
        {
            services.AddSingleton<IGitHubClient, GitHubClient>(s =>
            {
                var gitHubSettings = s.GetService<IOptions<GitHubSettings>>().Value;
                return new GitHubClient(new ProductHeaderValue(gitHubSettings.ProductHeaderValue))
                {
                    Credentials = new Credentials(gitHubSettings.PersonalAccessToken)
                };
            });
            services.AddTransient<IIssuesRepository, IssuesRepository>();
        }
    }
}