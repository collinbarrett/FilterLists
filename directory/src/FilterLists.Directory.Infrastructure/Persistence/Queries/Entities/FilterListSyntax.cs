namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListSyntax
    {
        public FilterList FilterList { get; private set; } = null!;
        public Syntax Syntax { get; private set; } = null!;
    }
}