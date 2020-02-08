using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class Tag : BaseEntity
    {
        public string Description { get; set; }
        public ICollection<FilterListTag> FilterListTags { get; set; }
        public string Name { get; set; }
    }
}