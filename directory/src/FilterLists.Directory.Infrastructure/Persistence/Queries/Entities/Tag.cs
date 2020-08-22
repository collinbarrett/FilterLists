using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Tag : IHaveSurrogateKey
    {
        public ushort Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public ICollection<FilterListTag> FilterListTags { get; private set; } = new HashSet<FilterListTag>();
    }
}