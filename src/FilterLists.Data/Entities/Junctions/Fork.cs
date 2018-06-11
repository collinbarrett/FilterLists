namespace FilterLists.Data.Entities.Junctions
{
    public class Fork : BaseJunction
    {
        public uint ForkFilterListId { get; set; }
        public FilterList ForkFilterList { get; set; }
        public uint UpstreamFilterListId { get; set; }
        public FilterList UpstreamFilterList { get; set; }
    }
}