using System;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class ViewUrlPartial
    {
        public FilterList FilterList { get; private set; } = null!;
        public ushort Position { get; private set; }
        public Uri Url { get; private set; } = null!;
    }
}