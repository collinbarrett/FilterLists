using System.Collections.Generic;
using System.Globalization;
using FilterLists.Archival.Domain.SeedWork;

namespace FilterLists.Archival.Domain.Lists
{
    public sealed class ListFileName : ValueObject
    {
        public ListFileName(int listId)
        {
            Value = listId.ToString(CultureInfo.InvariantCulture).PadLeft(5, '0');
        }

        public string Value { get; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return new[] {Value};
        }
    }
}
