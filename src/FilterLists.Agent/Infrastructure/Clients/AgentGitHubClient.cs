using System.Collections.Generic;
using System.Threading.Tasks;
using FilterLists.Agent.AppSettings;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Octokit;

namespace FilterLists.Agent.Infrastructure.Clients
{
    public interface IAgentGitHubClient
    {
        Task<IReadOnlyList<Issue>> GetAllIssues(RepositoryIssueRequest repositoryIssueRequest);

        Task<Issue> CreateIssue(NewIssue newIssue);

        Task<Issue> UpdateIssue(int issueNumber, IssueUpdate updateIssue);
    }

    public class AgentGitHubClient : IAgentGitHubClient
    {
        private readonly GitHubClient _gitHubClient;
        private readonly GitHub _gitHubOptions;
        private readonly ILogger<AgentGitHubClient> _logger;

        public AgentGitHubClient(IOptions<GitHub> gitHubOptions, ILogger<AgentGitHubClient> logger)
        {
            _gitHubOptions = gitHubOptions.Value;
            _logger = logger;
            _gitHubClient = new GitHubClient(new ProductHeaderValue(_gitHubOptions.ProductHeaderValue))
            {
                Credentials = new Credentials(_gitHubOptions.PersonalAccessToken)
            };
        }

        public async Task<IReadOnlyList<Issue>> GetAllIssues(RepositoryIssueRequest repositoryIssueRequest)
        {
            try
            {
                return await _gitHubClient.Issue.GetAllForRepository(_gitHubOptions.RepositoryOwner,
                    _gitHubOptions.Repository, repositoryIssueRequest);
            }
            catch (ApiException ex)
            {
                _logger.LogError(ex, "Failed getting all Issues from the GitHub API.");
                return null;
            }
        }

        public async Task<Issue> CreateIssue(NewIssue newIssue)
        {
            try
            {
                return await _gitHubClient.Issue.Create(_gitHubOptions.RepositoryOwner, _gitHubOptions.Repository,
                    newIssue);
            }
            catch (ApiException ex)
            {
                _logger.LogError(ex, "Failed creating Issue with the GitHub API.");
                return null;
            }
        }

        public async Task<Issue> UpdateIssue(int issueNumber, IssueUpdate updateIssue)
        {
            try
            {
                return await _gitHubClient.Issue.Update(_gitHubOptions.RepositoryOwner, _gitHubOptions.Repository,
                    issueNumber, updateIssue);
            }
            catch (ApiException ex)
            {
                _logger.LogError(ex, "Failed updating Issue with the GitHub API.");
                return null;
            }
        }
    }
}