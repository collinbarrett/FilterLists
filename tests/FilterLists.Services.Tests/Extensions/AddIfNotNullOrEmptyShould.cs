using System.Collections.Generic;
using System.Collections.ObjectModel;
using FilterLists.Services.Extensions;
using Xunit;

namespace FilterLists.Services.Tests.Extensions
{
    public class AddIfNotNullOrEmptyShould
    {
        public AddIfNotNullOrEmptyShould() =>
            sut = new Collection<string>();

        private readonly ICollection<string> sut;
        private string item;

        [Fact]
        public void AddIfNotNullOrEmpty()
        {
            item = "item";
            sut.AddIfNotNullOrEmpty(item);
            Assert.Contains(item, sut);
        }

        [Fact]
        public void NotAddIfEmpty()
        {
            item = "";
            sut.AddIfNotNullOrEmpty(item);
            Assert.DoesNotContain(item, sut);
        }

        [Fact]
        public void NotAddIfNull()
        {
            item = null;
            sut.AddIfNotNullOrEmpty(item);
            Assert.DoesNotContain(item, sut);
        }
    }
}