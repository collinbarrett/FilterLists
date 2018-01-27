using System;

namespace FilterLists.Data.Entities.Junctions
{
    public class FilterListRule
    {
        public DateTime CreatedDateUtc { get; set; }

        public int FilterListId { get; set; }
        public FilterList FilterList { get; set; }

        public int RuleId { get; set; }
        public Rule Rule { get; set; }
    }
}