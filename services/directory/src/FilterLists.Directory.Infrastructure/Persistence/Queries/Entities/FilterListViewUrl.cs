using System;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListViewUrl
    {
        public int SegmentNumber { get; private set; }
        public int Primariness { get; private set; }
        public Uri Url { get; private set; } = null!;
    }
}