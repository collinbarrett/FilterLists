using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Maintainer : IHaveSurrogateKey
    {
        public ushort Id { get; private set; }
        public string Name { get; private set; } = null!;
        public Uri? Url { get; private set; }
        public string? EmailAddress { get; private set; }
        public string? TwitterHandle { get; private set; }
        public ICollection<FilterListMaintainer> FilterListMaintainers { get; private set; } = new HashSet<FilterListMaintainer>();
    }
}