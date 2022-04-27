using System;

namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record License
{
    public long Id { get; init; }
    public string Name { get; init; } = default!;
    public Uri? Url { get; init; }
    public bool PermitsModification { get; init; }
    public bool PermitsDistribution { get; init; }
    public bool PermitsCommercialUse { get; init; }
}