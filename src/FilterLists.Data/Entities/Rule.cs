using System;
using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class Rule
    {
        public int Id { get; set; }
        public DateTime CreatedDateUtc { get; set; }

        public string Raw { get; set; }

        public ICollection<FilterListRule> FilterListRules { get; set; }
    }
}