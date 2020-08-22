using System;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class License: ISurrogateKey
    {
        public long Id { get; set; }
        public string GitHubKey { get; set; }
        public string Name { get; set; }
        public Uri Url { get; set; }
    }
}