namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record FilterListLanguage
{
    public long FilterListId { get; init; }
    public long LanguageId { get; init; }
}