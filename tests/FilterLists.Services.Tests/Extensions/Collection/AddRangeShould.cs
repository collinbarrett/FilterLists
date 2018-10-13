using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using FilterLists.Services.Extensions;
using Xunit;

namespace FilterLists.Services.Tests.Extensions.Collection
{
    public class AddRangeShould
    {
        private readonly ICollection<string> sut = new Collection<string>();
        private IEnumerable<string> range;

        [Fact]
        public void AddCollectionOfStrings()
        {
            range = new Collection<string> {"item1", "item2"};
            sut.AddRange(range);
            Assert.True(!range.Except(sut).Any());
        }

        [Fact]
        public void AddListOfStrings()
        {
            range = new List<string> {"item1", "item2"};
            sut.AddRange(range);
            Assert.True(!range.Except(sut).Any());
        }
    }
}