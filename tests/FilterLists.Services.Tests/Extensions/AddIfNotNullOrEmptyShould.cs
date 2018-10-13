using System.Collections.ObjectModel;
using FilterLists.Services.Extensions;
using Xunit;

namespace FilterLists.Services.Tests.Extensions
{
    public class AddIfNotNullOrEmptyShould
    {
        [Fact]
        public void AddIfNotNullOrEmpty()
        {
            var sut = new Collection<string>();
            const string item = "item";

            sut.AddIfNotNullOrEmpty(item);

            Assert.Contains(item, sut);
        }
    }
}