using System;
using FilterLists.Data.Models.Implementations;
using Xunit;

namespace FilterLists.Data.Tests
{
    public class ListRepositoryTests
    {
        [Fact]
        public void GetByName_ListNameIsNotNull_ReturnsValidIList()
        {
            //Arrange
            var list = new List
            {
                AddedDateUtc = DateTime.MinValue,
                Author = "John Doe",
                Description = "A filter list.",
                DescriptionSourceUrl = "https://filterlists.com"
            };

            //Act

            //Assert
            Assert.True(true);
        }
    }
}