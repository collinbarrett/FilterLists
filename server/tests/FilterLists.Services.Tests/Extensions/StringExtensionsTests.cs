using System;
using FilterLists.Services.Extensions;
using Xunit;

namespace FilterLists.Services.Tests.Extensions
{
    public class StringExtensionsTests
    {
        private const string Sut = "abcdeabcde";

        [Theory]
        [InlineData(1, 'a', 0)]
        [InlineData(2, 'a', 5)]
        public void GetNthIndexOfChar_NthIndexOfCharExists_ReturnsNthIndexOfChar(int n, char c, int expectedIndex)
        {
            var actualIndex = Sut.GetNthIndexOfChar(n, c);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Theory]
        [InlineData(3, 'a')]
        [InlineData(1, 'f')]
        public void GetNthIndexOfChar_NthIndexOfCharDoesNotExist_ReturnsNegativeOne(int n, char c)
        {
            var actualIndex = Sut.GetNthIndexOfChar(n, c);
            Assert.Equal(-1, actualIndex);
        }

        [Theory]
        [InlineData(0, 'a')]
        [InlineData(-1, 'a')]
        public void GetNthIndexOfChar_NLessThanOne_ThrowsArgumentOutOfRangeException(int n, char c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Sut.GetNthIndexOfChar(n, c));
        }

        [Theory]
        [InlineData("abp://www.google.com")]
        [InlineData("www.google.com")]
        [InlineData("google")]
        public void IsValidHttpOrHttpsUrl_NonHttpOrHttpsPrefixedUrl_ReturnsFalse(string url)
        {
            Assert.False(url.IsValidHttpOrHttpsUrl());
        }

        [Fact]
        public void IsValidHttpOrHttpsUrl_ValidHttpsUrl_ReturnsTrue()
        {
            const string httpsUrl = "https://www.google.com";
            Assert.True(httpsUrl.IsValidHttpOrHttpsUrl());
        }

        [Fact]
        public void IsValidHttpOrHttpsUrl_ValidHttpUrl_ReturnsTrue()
        {
            const string httpUrl = "http://www.google.com";
            Assert.True(httpUrl.IsValidHttpOrHttpsUrl());
        }
    }
}