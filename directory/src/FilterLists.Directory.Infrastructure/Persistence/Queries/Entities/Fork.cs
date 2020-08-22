namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Fork
    {
        public FilterList UpstreamFilterList { get; } = null!;
        public FilterList ForkFilterList { get; } = null!;
    }
}