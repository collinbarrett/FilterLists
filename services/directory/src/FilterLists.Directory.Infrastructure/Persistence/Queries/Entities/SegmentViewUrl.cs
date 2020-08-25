using System;
using System.Collections.Generic;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class SegmentViewUrl
    {
        public FilterList FilterList { get; private set; } = null!;
        public int Position { get; private set; }
        public Uri Url { get; private set; } = null!;
        public IReadOnlyCollection<SegmentViewUrlMirror> SegmentViewUrlMirrors { get; private set; } = new HashSet<SegmentViewUrlMirror>();
    }
}