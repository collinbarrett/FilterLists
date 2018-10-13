using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using FilterLists.Services.Extensions;
using Xunit;

namespace FilterLists.Services.Tests.Extensions
{
    public abstract class CollectionExtensionShould
    {
        protected readonly ICollection<string> Sut;

        protected CollectionExtensionShould() =>
            Sut = new Collection<string>();
    }

    public class AddIfNotNullOrEmptyShould : CollectionExtensionShould
    {
        private string item;

        [Fact]
        public void AddIfNotNullOrEmpty()
        {
            item = "item";
            Sut.AddIfNotNullOrEmpty(item);
            Assert.Contains(item, Sut);
        }

        [Fact]
        public void NotAddIfEmpty()
        {
            item = "";
            Sut.AddIfNotNullOrEmpty(item);
            Assert.DoesNotContain(item, Sut);
        }

        [Fact]
        public void NotAddIfNull()
        {
            item = null;
            Sut.AddIfNotNullOrEmpty(item);
            Assert.DoesNotContain(item, Sut);
        }
    }

    public class AddRangeShould : CollectionExtensionShould
    {
        private IEnumerable<string> range;

        [Fact]
        public void AddCollectionOfStrings()
        {
            range = new Collection<string> {"item1", "item2"};
            Sut.AddRange(range);
            Assert.True(!range.Except(Sut).Any());
        }

        [Fact]
        public void AddListOfStrings()
        {
            range = new List<string> {"item1", "item2"};
            Sut.AddRange(range);
            Assert.True(!range.Except(Sut).Any());
        }
    }
}