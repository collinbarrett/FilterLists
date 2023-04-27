namespace FilterLists.Api.Persistence.Entities;

internal record SoftwareSyntax
{
    public int SoftwareId { get; init; }
    public int SyntaxId { get; init; }
}