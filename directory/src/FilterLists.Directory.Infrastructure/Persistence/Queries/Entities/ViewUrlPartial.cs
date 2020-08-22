using System;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class ViewUrlPartial
    {
        public FilterList FilterList { get; set; }
        public ushort Position { get; set; }
        public Uri Url { get; set; }
    }
}