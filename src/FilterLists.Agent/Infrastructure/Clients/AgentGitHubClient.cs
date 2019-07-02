using System.Collections.Generic;
using System.Threading.Tasks;
using FilterLists.Agent.AppSettings;
using Microsoft.Extensions.Options;
using Octokit;

namespace FilterLists.Agent.Infrastructure.Clients
{
    public interface IAgentGitHubClient
    {
        Task<IReadOnlyList<Issue>> GetAllIssues(RepositoryIssueRequest repositoryIssueRequest);
    }

    public class AgentGitHubClient : IAgentGitHubClient
    {
        private readonly GitHubClient _gitHubClient;
        private readonly GitHub _gitHubOptions;

        public AgentGitHubClient(IOptions<GitHub> gitHubOptions)
        {
            _gitHubOptions = gitHubOptions.Value;
            _gitHubClient = new GitHubClient(new ProductHeaderValue(_gitHubOptions.ProductHeaderValue))
            {
                Credentials = new Credentials(_gitHubOptions.PersonalAccessToken)
            };
        }

        public async Task<IReadOnlyList<Issue>> GetAllIssues(RepositoryIssueRequest repositoryIssueRequest)
        {
            return await _gitHubClient.Issue.GetAllForRepository(_gitHubOptions.RepositoryOwner,
                _gitHubOptions.Repository, repositoryIssueRequest);
        }
    }
}