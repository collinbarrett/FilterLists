using System;
using System.Collections.Generic;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class License
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? GitHubKey { get; private set; }
        public Uri? Url { get; private set; }
        public IReadOnlyCollection<FilterList> FilterLists { get; private set; } = new HashSet<FilterList>();
    }
}