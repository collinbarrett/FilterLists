using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilterLists.Services.GitHub.Models;
using JetBrains.Annotations;
using Octokit;

namespace FilterLists.Services.GitHub
{
    [UsedImplicitly]
    public class GitHubService
    {
        private const string RawFileUrlRoot = "raw.githubusercontent.com";
        private const string ProductHeader = "FilterLists";
        private const string ReadOnlyPersonalAccessToken = "25ef3c8e20d2fcacf1583e7650b63cfa3e784fec";
        private readonly GitHubClient client;

        public GitHubService() =>
            client = new GitHubClient(new ProductHeaderValue(ProductHeader))
            {
                Credentials = new Credentials(ReadOnlyPersonalAccessToken)
            };

        public async Task<CommitDates> GetCommitDatesAsync(string rawFileUrl)
        {
            if (!IsValidUrl(rawFileUrl))
                return null;
            var commits = await GetAllCommits(rawFileUrl);
            return new CommitDates
            {
                First = commits.LastOrDefault()?.Commit.Author.Date.DateTime,
                Last = commits.FirstOrDefault()?.Commit.Author.Date.DateTime
            };
        }

        private static bool IsValidUrl(string fileRawUrl) => fileRawUrl.Contains(RawFileUrlRoot);

        private async Task<IReadOnlyList<GitHubCommit>> GetAllCommits(string rawFileUrl)
        {
            var meta = ParseMeta(rawFileUrl);
            return await client.Repository.Commit.GetAll(
                meta.Owner,
                meta.RepositoryName,
                new CommitRequest {Path = meta.FilePath});
        }

        private static FileMeta ParseMeta(string rawFileUrl)
        {
            var urlPath = rawFileUrl.Split(new[] {RawFileUrlRoot}, StringSplitOptions.None)[1];
            var urlPathSlugs = urlPath.Split('/');
            var filePath = string.Empty;
            for (var i = 4; i < urlPathSlugs.Length; i++)
                filePath = filePath + '/' + urlPathSlugs[i];
            return new FileMeta
            {
                Owner = urlPathSlugs[1],
                RepositoryName = urlPathSlugs[2],
                FilePath = filePath.Substring(1)
            };
        }

        private class FileMeta
        {
            public string Owner { get; set; }
            public string RepositoryName { get; set; }
            public string FilePath { get; set; }
        }
    }
}