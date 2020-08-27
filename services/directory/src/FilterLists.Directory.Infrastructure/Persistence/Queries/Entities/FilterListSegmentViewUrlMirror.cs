using System;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListSegmentViewUrlMirror
    {
        public FilterListSegmentViewUrl SegmentViewUrl { get; private set; } = null!;
        public int Position { get; private set; }
        public Uri Url { get; private set; } = null!;
    }
}