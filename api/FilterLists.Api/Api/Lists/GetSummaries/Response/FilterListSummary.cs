using System.Collections.Generic;

namespace FilterLists.Api.Api.Lists.GetSummaries.Response;

public record FilterListSummary
{
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public IEnumerable<string> Software { get; init; } = new HashSet<string>();
    public IEnumerable<string> Syntaxes { get; init; } = new HashSet<string>();
    public IEnumerable<string> Languages { get; init; } = new HashSet<string>();
    public IEnumerable<string> Tags { get; init; } = new HashSet<string>();
    public IEnumerable<string> Maintainers { get; init; } = new HashSet<string>();
    public string License { get; init; } = default!;
}