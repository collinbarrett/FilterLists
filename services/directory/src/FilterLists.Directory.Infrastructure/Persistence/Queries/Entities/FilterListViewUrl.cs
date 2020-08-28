using System;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListViewUrl
    {
        public short SegmentNumber { get; set; }
        public short Primariness { get; set; }
        public Uri Url { get; set; } = null!;
    }
}