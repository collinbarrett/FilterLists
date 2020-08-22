namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListMaintainer
    {
        public FilterList FilterList { get; } = null!;
        public Maintainer Maintainer { get; } = null!;
    }
}