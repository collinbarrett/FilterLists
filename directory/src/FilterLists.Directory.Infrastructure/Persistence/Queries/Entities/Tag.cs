using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Tag : IHaveSurrogateKey
    {
        public ushort Id { get; }
        public string Name { get; } = null!;
        public string? Description { get; }
        public ICollection<FilterListTag> FilterListTags { get; } = new HashSet<FilterListTag>();
    }
}