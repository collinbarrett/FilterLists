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
        public async Task ReturnCorrectCommitDatesForValidGitHubRawUrl()
        {
            const string rawFileUrl = "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/LICENSE";
            var expectedCommitDates = new CommitDates
            {
                First = DateTime.Parse("2016-12-10T20:28:16.0000000"),
                Last = DateTime.Parse("2018-01-24T00:08:21.0000000")
            };
            var actualCommitDates = await new GitHubService().GetCommitDatesAsync(rawFileUrl);
            Assert.Equal(expectedCommitDates.First, actualCommitDates.First);
            Assert.Equal(expectedCommitDates.Last, actualCommitDates.Last);
        }
    }
}