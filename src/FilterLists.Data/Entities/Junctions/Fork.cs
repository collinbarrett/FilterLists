namespace FilterLists.Data.Entities.Junctions
{
    public class Fork : BaseJunctionEntity
    {
        public uint ForkFilterListId { get; set; }
        public FilterList ForkFilterList { get; set; }
        public uint UpstreamFilterListId { get; set; }
        public FilterList UpstreamFilterList { get; set; }
    }
}