namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListMaintainer
    {
        public FilterList FilterList { get; private set; } = null!;
        public Maintainer Maintainer { get; private set; } = null!;
    }
}