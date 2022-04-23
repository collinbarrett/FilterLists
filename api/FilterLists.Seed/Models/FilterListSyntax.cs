namespace FilterLists.Seed.Models;

public record FilterListSyntax
{
    public long FilterListId { get; init; }
    public FilterList FilterList { get; init; } = default!;
    public long SyntaxId { get; init; }
    public Syntax Syntax { get; init; } = default!;
}