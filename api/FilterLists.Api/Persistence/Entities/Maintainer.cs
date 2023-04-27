﻿using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

public record Maintainer
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public Uri? Url { get; init; }
    public string? EmailAddress { get; init; }
    public string? TwitterHandle { get; init; }
    public IEnumerable<FilterList> FilterLists { get; init; } = new HashSet<FilterList>();
}

internal class MaintainerTypeConfiguration : IEntityTypeConfiguration<Maintainer>
{
    public virtual void Configure(EntityTypeBuilder<Maintainer> builder)
    {
        builder.HasIndex(m => m.Name)
            .IsUnique();
        builder.HasDataJsonFile<Maintainer>();
    }
}