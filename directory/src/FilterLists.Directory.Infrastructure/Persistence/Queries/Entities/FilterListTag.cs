namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListTag
    {
        public FilterList FilterList { get; private set; } = null!;
        public Tag Tag { get; private set; } = null!;
    }
}