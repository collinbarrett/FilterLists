namespace FilterLists.Api.Persistence.Entities;

internal record FilterListLanguage
{
    public int FilterListId { get; init; }
    public int LanguageId { get; init; }
}