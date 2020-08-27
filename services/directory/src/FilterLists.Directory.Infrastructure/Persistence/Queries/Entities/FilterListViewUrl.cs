using System;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListViewUrl
    {
        public int SegmentNumber { get; set; }
        public int Primariness { get; set; }
        public string Url { get; set; } = null!;
    }
}