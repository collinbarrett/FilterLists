using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class License: IHaveSurrogateKey
    {
        public ushort Id { get; set; }
        public string GitHubKey { get; set; }
        public string Name { get; set; }
        public Uri Url { get; set; }
        public ICollection<FilterList> FilterLists { get; set; }
    }
}