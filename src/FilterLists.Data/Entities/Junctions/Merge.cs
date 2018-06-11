namespace FilterLists.Data.Entities.Junctions
{
    public class Merge : BaseJunction
    {
        public uint MergeFilterListId { get; set; }
        public FilterList MergeFilterList { get; set; }
        public uint UpstreamFilterListId { get; set; }
        public FilterList UpstreamFilterList { get; set; }
    }
}