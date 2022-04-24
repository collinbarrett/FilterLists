namespace FilterLists.Api.Application.Lists.PostSeed.Models;

public record FilterListLanguage
{
    public long FilterListId { get; init; }
    public long LanguageId { get; init; }
}