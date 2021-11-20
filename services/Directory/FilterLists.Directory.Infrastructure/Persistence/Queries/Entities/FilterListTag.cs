﻿using System.Globalization;
using EFCore.NamingConventions.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterListTag
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; } = null!;
    public int TagId { get; init; }
    public Tag Tag { get; } = null!;
}

internal class FilterListTagTypeConfiguration : IEntityTypeConfiguration<FilterListTag>
{
    public virtual void Configure(EntityTypeBuilder<FilterListTag> builder)
    {
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

        builder.ToTable($"{nr.RewriteName(nameof(FilterListTag))}s");
        builder.HasKey(flt => new { flt.FilterListId, flt.TagId });
        builder.HasQueryFilter(flt => flt.FilterList.IsApproved && flt.Tag.IsApproved);
        builder.HasDataJsonFile<FilterListTag>();
    }
}
