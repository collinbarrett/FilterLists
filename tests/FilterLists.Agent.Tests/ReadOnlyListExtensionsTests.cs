using System;
using System.Collections.Generic;
using FilterLists.Agent.Extensions;
using Xunit;

namespace FilterLists.Agent.Tests
{
    public class ReadOnlyListExtensionsTests
    {
        [Fact]
        public void FirstOrDefault_WithEmptyList_ReturnsDefault()
        {
            var list = (IReadOnlyList<int>)new List<int>();
            var sut = list.FirstOrDefault();
            Assert.Equal(default, sut);
        }

        [Fact]
        public void FirstOrDefault_WithMoreThanOneListElement_ReturnsFirstListElement()
        {
            var list = (IReadOnlyList<int>)new List<int> {1, 2, 3};
            var sut = list.FirstOrDefault();
            Assert.Equal(1, sut);
        }

        [Fact]
        public void FirstOrDefault_WithNullParameter_ThrowsArgumentNullException()
        {
            var list = (IReadOnlyList<int>)null;
            Assert.Throws<ArgumentNullException>(() => list.FirstOrDefault());
        }

        [Fact]
        public void FirstOrDefault_WithOneListElement_ReturnsFirstListElement()
        {
            var list = (IReadOnlyList<int>)new List<int> {0};
            var sut = list.FirstOrDefault();
            Assert.Equal(0, sut);
        }
    }
}