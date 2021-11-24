namespace FilterLists.Directory.Api.Contracts.Models;

public record ListVm
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public int? LicenseId { get; init; }
    public IEnumerable<int> SyntaxIds { get; init; } = new HashSet<int>();
    public IEnumerable<string> Iso6391s { get; init; } = new HashSet<string>();
    public IEnumerable<int> TagIds { get; init; } = new HashSet<int>();
    public Uri? PrimaryViewUrl { get; init; }
    public IEnumerable<int> MaintainerIds { get; init; } = new HashSet<int>();
}
