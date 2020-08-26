using System;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListSegmentViewUrlMirror
    {
        public FilterListSegmentViewUrl SegmentViewUrl { get; private set; } = null!;
        public Uri Url { get; private set; } = null!;
    }
}