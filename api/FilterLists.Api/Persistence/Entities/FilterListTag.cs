namespace FilterLists.Api.Persistence.Entities;

internal record FilterListTag
{
    public int FilterListId { get; init; }
    public int TagId { get; init; }
}