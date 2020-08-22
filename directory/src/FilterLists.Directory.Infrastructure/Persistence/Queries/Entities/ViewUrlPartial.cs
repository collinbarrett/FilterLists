using System;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class ViewUrlPartial
    {
        public FilterList FilterList { get; } = null!;
        public ushort Position { get; }
        public Uri Url { get; } = null!;
    }
}