namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Fork
    {
        public FilterList UpstreamFilterList { get; private set; } = null!;
        public FilterList ForkFilterList { get; private set; } = null!;
    }
}