using System;
using System.Threading;
using FilterLists.Services.Extensions;
using Xunit;

namespace FilterLists.Services.Tests.Extensions.Task
{
    public class TimeoutAfterShould
    {
        private readonly System.Threading.Tasks.Task sut =
            System.Threading.Tasks.Task.Run(() => { Thread.Sleep(1000); });

        [Fact]
        public async void CompleteSuccessfullyIfTimeToCompleteIsLessThanTimeout()
        {
            var fifteenSecondTimeout = new TimeSpan(0, 0, 15);
            await sut.TimeoutAfter(fifteenSecondTimeout);
            Assert.True(sut.IsCompletedSuccessfully);
        }

        [Fact]
        public async void ThrowTimeoutExceptionIfTimeToCompleteIsGreaterThanTimeout()
        {
            var oneTickTimeout = new TimeSpan(1);
            await Assert.ThrowsAsync<TimeoutException>(() =>
                sut.TimeoutAfter(oneTickTimeout));
        }
    }
}