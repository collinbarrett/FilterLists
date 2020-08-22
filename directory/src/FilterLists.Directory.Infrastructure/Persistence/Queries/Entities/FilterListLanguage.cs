namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListLanguage
    {
        public FilterList FilterList { get; private set; } = null!;
        public Language Language { get; private set; } = null!;
    }
}