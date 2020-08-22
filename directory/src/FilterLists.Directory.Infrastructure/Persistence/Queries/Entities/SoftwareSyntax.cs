namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class SoftwareSyntax
    {
        public Software Software { get; private set; } = null!;
        public Syntax Syntax { get; private set; } = null!;
    }
}