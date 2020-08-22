namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Dependent
    {
        public FilterList DependencyFilterList { get; private set; } = null!;
        public FilterList DependentFilterList { get; private set; } = null!;
    }
}