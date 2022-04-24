namespace FilterLists.Api.Application.Lists.PostSeed.Models;

public record Language
{
    public long Id { get; init; }
    public string Iso6391 { get; init; } = default!;
}