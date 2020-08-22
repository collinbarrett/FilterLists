using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class License : IHaveSurrogateKey
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? GitHubKey { get; private set; }
        public Uri? Url { get; private set; }
        public ICollection<FilterList> FilterLists { get; private set; } = new HashSet<FilterList>();
    }
}