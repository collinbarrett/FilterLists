using System;
using System.Collections.Generic;

namespace FilterLists.Api.Api.Lists.Put.Request;

public record Syntax
{
    public long Id { get; init; }
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public Uri? Url { get; init; }
    public IEnumerable<Software> Software { get; init; } = new HashSet<Software>();
}