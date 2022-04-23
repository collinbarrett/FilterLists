using System;
using System.Collections.Generic;

namespace FilterLists.Seed.Models;

public record Syntax
{
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public Uri? Url { get; init; }
    public IEnumerable<FilterListSyntax> FilterListSyntaxes { get; init; } = new HashSet<FilterListSyntax>();
    public IEnumerable<SoftwareSyntax> SoftwareSyntaxes { get; init; } = new HashSet<SoftwareSyntax>();
}