using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using FilterLists.Services.Extensions;
using Xunit;

namespace FilterLists.Services.Tests.Extensions
{
    public class CollectionExtensionsTests
    {
        private readonly ICollection<string> _sut = new Collection<string>();
        private IEnumerable<string> _range;
        private string _item;

        [Fact]
        public void AddIfNotNullOrEmpty_NullString_AddsNothing()
        {
            _item = null;
            _sut.AddIfNotNullOrEmpty(_item);
            Assert.DoesNotContain(_item, _sut);
        }

        [Fact]
        public void AddRange_EmptyCollection_AddsNothing()
        {
            _range = new Collection<string>();
            _sut.AddRange(_range);
            Assert.Empty(_sut);
        }

        [Fact]
        public void AddIfNotNullOrEmpty_EmptyString_AddsNothing()
        {
            _item = "";
            _sut.AddIfNotNullOrEmpty(_item);
            Assert.DoesNotContain(_item, _sut);
        }

        [Fact]
        public void AddIfNotNullOrEmpty_NonNullOrEmptyString_AddsParam()
        {
            _item = "item";
            _sut.AddIfNotNullOrEmpty(_item);
            Assert.Contains(_item, _sut);
        }

        [Fact]
        public void AddRange_EmptyList_AddsNothing()
        {
            _range = new List<string>();
            _sut.AddRange(_range);
            Assert.Empty(_sut);
        }

        [Fact]
        public void AddRange_StringCollection_AddsParam()
        {
            _range = new Collection<string> {"item1", "item2"};
            _sut.AddRange(_range);
            Assert.True(!_range.Except(_sut).Any());
        }

        [Fact]
        public void AddRange_StringList_AddsParam()
        {
            _range = new List<string> {"item1", "item2"};
            _sut.AddRange(_range);
            Assert.True(!_range.Except(_sut).Any());
        }
    }
}