using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using FilterLists.Services.Extensions;
using Xunit;

namespace FilterLists.Services.Tests.Extensions
{
    public class CollectionExtensionsTests
    {
        private readonly ICollection<string> sut = new Collection<string>();
        private IEnumerable<string> range;
        private string item;

        [Fact]
        public void AddIfNotNullOrEmpty_EmptyString_AddsNothing()
        {
            item = "";
            sut.AddIfNotNullOrEmpty(item);
            Assert.DoesNotContain(item, sut);
        }

        [Fact]
        public void AddIfNotNullOrEmpty_NonNullOrEmptyString_AddsParam()
        {
            item = "item";
            sut.AddIfNotNullOrEmpty(item);
            Assert.Contains(item, sut);
        }

        [Fact]
        public void AddIfNotNullOrEmpty_NullString_AddsNothing()
        {
            item = null;
            sut.AddIfNotNullOrEmpty(item);
            Assert.DoesNotContain(item, sut);
        }

        [Fact]
        public void AddRange_EmptyCollection_AddsNothing()
        {
            range = new Collection<string>();
            sut.AddRange(range);
            Assert.Empty(sut);
        }

        [Fact]
        public void AddRange_EmptyList_AddsNothing()
        {
            range = new List<string>();
            sut.AddRange(range);
            Assert.Empty(sut);
        }

        [Fact]
        public void AddRange_StringCollection_AddsParam()
        {
            range = new Collection<string> {"item1", "item2"};
            sut.AddRange(range);
            Assert.True(!range.Except(sut).Any());
        }

        [Fact]
        public void AddRange_StringList_AddsParam()
        {
            range = new List<string> {"item1", "item2"};
            sut.AddRange(range);
            Assert.True(!range.Except(sut).Any());
        }
    }
}