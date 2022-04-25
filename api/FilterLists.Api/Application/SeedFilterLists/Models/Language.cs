namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record Language
{
    public long Id { get; init; }
    public string Iso6391 { get; init; } = default!;
}