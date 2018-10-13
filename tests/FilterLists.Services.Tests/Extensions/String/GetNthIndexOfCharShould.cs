using System;
using FilterLists.Services.Extensions;
using Xunit;

namespace FilterLists.Services.Tests.Extensions.String
{
    public class GetNthIndexOfCharShould
    {
        private const string Sut = "abcdeabcde";

        [Theory]
        [InlineData(1, 'a', 0)]
        [InlineData(2, 'a', 5)]
        public void ReturnNthIndexOfCharIfExists(int n, char c, int expectedIndex)
        {
            Assert.Equal(expectedIndex, Sut.GetNthIndexOfChar(n, c));
        }

        [Theory]
        [InlineData(3, 'a')]
        [InlineData(1, 'f')]
        public void ReturnNegativeOneIfDoesNotExist(int n, char c)
        {
            Assert.Equal(-1, Sut.GetNthIndexOfChar(n, c));
        }

        [Theory]
        [InlineData(0, 'a')]
        [InlineData(-1, 'a')]
        public void ThrowArgumentOutOfRangeExceptionIfInvalidN(int n, char c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Sut.GetNthIndexOfChar(n, c));
        }
    }
}