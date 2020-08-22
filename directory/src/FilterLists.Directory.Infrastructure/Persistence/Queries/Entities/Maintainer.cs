using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Maintainer : IHaveSurrogateKey
    {
        public ushort Id { get; }
        public string Name { get; } = null!;
        public Uri? Url { get; }
        public string? EmailAddress { get; }
        public string? TwitterHandle { get; }
        public ICollection<FilterListMaintainer> FilterListMaintainers { get; } = new HashSet<FilterListMaintainer>();
    }
}