namespace FilterLists.Seed.Models;

public record SoftwareSyntax
{
    public long SoftwareId { get; init; }
    public Software Software { get; init; } = default!;
    public long SyntaxId { get; init; }
    public Syntax Syntax { get; init; } = default!;
}