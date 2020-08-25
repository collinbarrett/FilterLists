using System;
using System.Collections.Generic;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Maintainer
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public Uri? Url { get; private set; }
        public string? EmailAddress { get; private set; }
        public string? TwitterHandle { get; private set; }
        public IReadOnlyCollection<FilterListMaintainer> FilterListMaintainers { get; private set; } = new HashSet<FilterListMaintainer>();
    }
}