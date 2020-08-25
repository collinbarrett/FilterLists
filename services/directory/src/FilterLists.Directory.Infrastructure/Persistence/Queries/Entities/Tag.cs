using System.Collections.Generic;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Tag
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public IReadOnlyCollection<FilterListTag> FilterListTags { get; private set; } = new HashSet<FilterListTag>();
    }
}