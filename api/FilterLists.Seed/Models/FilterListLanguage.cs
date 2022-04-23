namespace FilterLists.Seed.Models;

public record FilterListLanguage
{
    public long FilterListId { get; init; }
    public FilterList FilterList { get; init; } = default!;
    public long LanguageId { get; init; }
    public Language Language { get; init; } = default!;
}