using System;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Services.Extensions;
using Xunit;

namespace FilterLists.Services.Tests.Extensions
{
    public class TaskExtensionsTests
    {
        private readonly Task sut = Task.Run(() => { Thread.Sleep(TimeSpan.FromSeconds(1)); });

        [Fact]
        public async Task TimeoutAfter_TimeToCompleteIsGreaterThanTimeout_ThrowsTimeoutException()
        {
            var oneTickTimeout = new TimeSpan(1);
            var taskWithTimeout = sut.TimeoutAfter(oneTickTimeout);
            await Assert.ThrowsAsync<TimeoutException>(() => taskWithTimeout);
        }

        [Fact]
        public async Task TimeoutAfter_TimeToCompleteIsLessThanTimeout_CompletesSuccessfully()
        {
            var twoSecondTimeout = new TimeSpan(0, 0, 2);
            await sut.TimeoutAfter(twoSecondTimeout);
            Assert.True(sut.IsCompletedSuccessfully);
        }
    }
}