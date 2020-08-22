namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListTag
    {
        public FilterList FilterList { get; } = null!;
        public Tag Tag { get; } = null!;
    }
}