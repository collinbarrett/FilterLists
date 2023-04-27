namespace FilterLists.Api.Persistence.Entities;

internal record FilterListSyntax
{
    public int FilterListId { get; init; }
    public int SyntaxId { get; init; }
}