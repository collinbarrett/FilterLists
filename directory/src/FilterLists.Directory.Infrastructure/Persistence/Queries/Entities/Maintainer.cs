using System;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Maintainer : ISurrogateKey
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Uri Url { get; set; }
        public string EmailAddress { get; set; }
        public string TwitterHandle { get; set; }
    }
}