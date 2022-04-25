namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record FilterList
{
    public long Id { get; init; }
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public long LicenseId { get; init; }
    public string? HomeUrl { get; init; }
    public string? OnionUrl { get; init; }
    public string? PolicyUrl { get; init; }
    public string? SubmissionUrl { get; init; }
    public string? IssuesUrl { get; init; }
    public string? ForumUrl { get; init; }
    public string? ChatUrl { get; init; }
    public string? EmailAddress { get; init; }
    public string? DonateUrl { get; init; }
}