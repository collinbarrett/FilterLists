using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Tag : IHaveSurrogateKey
    {
        public ushort Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<FilterListTag> FilterListTags { get; set; }
    }
}