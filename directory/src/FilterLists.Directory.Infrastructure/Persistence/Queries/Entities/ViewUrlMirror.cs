using System;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class ViewUrlMirror : IHaveSurrogateKey
    {
        public ushort Id { get; }
        public FilterList FilterList { get; } = null!;
        public Uri Url { get; } = null!;
    }
}