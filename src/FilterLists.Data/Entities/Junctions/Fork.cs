using System;

namespace FilterLists.Data.Entities.Junctions
{
    public class Fork
    {
        public DateTime CreatedDateUtc { get; set; }

        public int ForkFilterListId { get; set; }
        public FilterList ForkFilterList { get; set; }

        public int UpstreamFilterListId { get; set; }
        public FilterList UpstreamFilterList { get; set; }
    }
}