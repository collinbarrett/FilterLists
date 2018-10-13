using System;
using System.Threading.Tasks;
using FilterLists.Services.GitHub;
using FilterLists.Services.GitHub.Models;
using Xunit;

namespace FilterLists.Services.Tests.GitHub
{
    public class GetCommitDatesAsyncShould
    {
        [Fact]
        public async Task ReturnCorrectFirstAndLastCommitDatesForValidGitHubRawUrl()
        {
            const string url = "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/LICENSE";
            var expectedDates = new CommitDates
            {
                First = DateTime.Parse("2016-12-10T20:28:16.0000000"),
                Last = DateTime.Parse("2018-01-24T00:08:21.0000000")
            };
            var actualDates = await new GitHubService().GetCommitDatesAsync(url);
            Assert.Equal(expectedDates.First, actualDates.First);
            Assert.Equal(expectedDates.Last, actualDates.Last);
        }

        [Fact]
        public async Task ReturnNullForInvalidGitHubRawUrl()
        {
            const string url = "https://github.com/collinbarrett/FilterLists/blob/master/.gitattributes";
            var actualDates = await new GitHubService().GetCommitDatesAsync(url);
            Assert.Null(actualDates);
        }

        [Fact]
        public async Task ReturnNullForValidGitHubRawUrlToNonexistentFile()
        {
            const string url = "https://github.com/collinbarrett/FilterLists/blob/master/doesnotexist";
            var actualDates = await new GitHubService().GetCommitDatesAsync(url);
            Assert.Null(actualDates);
        }

        [Fact]
        public async Task ReturnSameFirstAndLastCommitDatesForValidGitHubRawUrlWithOnlyOneCommit()
        {
            const string url = "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/.gitattributes";
            var expectedDate = DateTime.Parse("2017-04-08T00:05:26.0000000");
            var actualDates = await new GitHubService().GetCommitDatesAsync(url);
            Assert.Equal(expectedDate, actualDates.First);
            Assert.Equal(expectedDate, actualDates.Last);
        }
    }
}