namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Dependent
    {
        public FilterList DependencyFilterList { get; } = null!;
        public FilterList DependentFilterList { get; } = null!;
    }
}