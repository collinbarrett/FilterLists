namespace FilterLists.Data.Entities.Junctions
{
    public class Merge : BaseJunction
    {
        public int MergeFilterListId { get; set; }
        public FilterList MergeFilterList { get; set; }

        public int UpstreamFilterListId { get; set; }
        public FilterList UpstreamFilterList { get; set; }
    }
}