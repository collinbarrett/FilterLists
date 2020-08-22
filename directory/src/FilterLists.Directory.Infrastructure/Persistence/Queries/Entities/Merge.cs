namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Merge
    {
        public FilterList IncludedInFilterList { get; private set; } = null!;
        public FilterList IncludesFilterList { get; private set; } = null!;
    }
}