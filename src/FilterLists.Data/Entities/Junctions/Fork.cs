namespace FilterLists.Data.Entities.Junctions
{
    public class Fork : BaseJunctionEntity
    {
        public int ForkFilterListId { get; set; }
        public FilterList ForkFilterList { get; set; }
        public int UpstreamFilterListId { get; set; }
        public FilterList UpstreamFilterList { get; set; }
    }
}