using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class License : IHaveSurrogateKey
    {
        public ushort Id { get; }
        public string Name { get; } = null!;
        public string? GitHubKey { get; }
        public Uri? Url { get; }
        public ICollection<FilterList> FilterLists { get; } = new HashSet<FilterList>();
    }
}