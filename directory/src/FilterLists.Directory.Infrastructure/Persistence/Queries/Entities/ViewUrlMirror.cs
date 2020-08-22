using System;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class ViewUrlMirror : IHaveSurrogateKey
    {
        public ushort Id { get; private set; }
        public FilterList FilterList { get; private set; } = null!;
        public Uri Url { get; private set; } = null!;
    }
}