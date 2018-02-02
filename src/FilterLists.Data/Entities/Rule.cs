using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class Rule : BaseEntity
    {
        public ICollection<FilterListRule> FilterListRules { get; set; }
        public string Raw { get; set; }
    }
}