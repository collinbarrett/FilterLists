using System;
using System.Collections.Generic;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListSegmentViewUrl
    {
        public FilterList FilterList { get; private set; } = null!;
        public int Position { get; private set; }
        public Uri Url { get; private set; } = null!;
        public IReadOnlyCollection<FilterListSegmentViewUrlMirror> Mirrors { get; private set; } = new HashSet<FilterListSegmentViewUrlMirror>();
    }
}