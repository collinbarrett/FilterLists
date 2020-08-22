namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Merge
    {
        public FilterList IncludedInFilterList { get; } = null!;
        public FilterList IncludesFilterList { get; } = null!;
    }
}