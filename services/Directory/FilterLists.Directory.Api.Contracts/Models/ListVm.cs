namespace FilterLists.Directory.Api.Contracts.Models
{
    public class ListVm
    {
        public int Id { get; init; }
        public string Name { get; init; } = null!;
        public string? Description { get; init; }
        public int? LicenseId { get; init; }
        public IEnumerable<int>? SyntaxIds { get; init; }
        public IEnumerable<string>? Iso6391s { get; init; }
        public IEnumerable<int>? TagIds { get; init; }
        public Uri? PrimaryViewUrl { get; init; }
        public IEnumerable<int>? MaintainerIds { get; init; }
    }
}
