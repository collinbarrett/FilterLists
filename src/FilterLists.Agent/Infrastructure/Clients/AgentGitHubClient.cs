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

        Task<Issue> UpdateIssue(int issueNumber, IssueUpdate issueUpdate);
    }

    public class AgentGitHubClient : IAgentGitHubClient
    {
        private const string ExceptionMessageSuffix = " from the GitHub API.";
        private readonly GitHubClient _gitHubClient;
        private readonly GitHubSettings _gitHubSettings;
        private readonly ILogger<AgentGitHubClient> _logger;

        public AgentGitHubClient(IOptions<GitHubSettings> gitHubOptions, ILogger<AgentGitHubClient> logger)
        {
            _gitHubSettings = gitHubOptions.Value;
            _logger = logger;
            _gitHubClient = new GitHubClient(new ProductHeaderValue(_gitHubSettings.ProductHeaderValue))
            {
                Credentials = new Credentials(_gitHubSettings.PersonalAccessToken)
            };
        }

        public async Task<IReadOnlyList<Issue>> GetAllIssues(RepositoryIssueRequest repositoryIssueRequest)
        {
            try
            {
                return await _gitHubClient.Issue.GetAllForRepository(_gitHubSettings.RepositoryOwner,
                    _gitHubSettings.Repository, repositoryIssueRequest);
            }
            catch (ApiException ex)
            {
                _logger.LogError(ex, $"Failed getting all Issues{ExceptionMessageSuffix}");
                return null;
            }
        }

        public async Task<Issue> CreateIssue(NewIssue newIssue)
        {
            try
            {
                return await _gitHubClient.Issue.Create(_gitHubSettings.RepositoryOwner, _gitHubSettings.Repository,
                    newIssue);
            }
            catch (ApiException ex)
            {
                _logger.LogError(ex, $"Failed creating Issue{ExceptionMessageSuffix}");
                return null;
            }
        }

        public async Task<Issue> UpdateIssue(int issueNumber, IssueUpdate issueUpdate)
        {
            try
            {
                return await _gitHubClient.Issue.Update(_gitHubSettings.RepositoryOwner, _gitHubSettings.Repository,
                    issueNumber, issueUpdate);
            }
            catch (ApiException ex)
            {
                _logger.LogError(ex, $"Failed updating Issue{ExceptionMessageSuffix}");
                return null;
            }
        }
    }
}