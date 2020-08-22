namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Fork
    {
        public FilterList UpstreamFilterList { get; set; }
        public FilterList ForkFilterList { get; set; }
    }
}