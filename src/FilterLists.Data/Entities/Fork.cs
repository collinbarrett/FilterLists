namespace FilterLists.Data.Entities
{
    public class Fork : BaseEntity
    {
        public int ForkFilterListId { get; set; }
        public FilterList ForkFilterList { get; set; }

        public int UpstreamFilterListId { get; set; }
        public FilterList UpstreamFilterList { get; set; }
    }
}