namespace FilterLists.Directory.Api.Contracts.Models;

public record ListVm
{
    public long Id { get; init; }
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public long? LicenseId { get; init; }
    public IEnumerable<long> SyntaxIds { get; init; } = new HashSet<long>();
    public IEnumerable<long> LanguageIds { get; init; } = new HashSet<long>();
    public IEnumerable<long> TagIds { get; init; } = new HashSet<long>();
    public Uri? PrimaryViewUrl { get; init; }
    public IEnumerable<long> MaintainerIds { get; init; } = new HashSet<long>();
}
