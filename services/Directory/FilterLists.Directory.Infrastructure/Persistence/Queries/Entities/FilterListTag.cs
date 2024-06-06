using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record FilterListTag
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = null!;
    public int TagId { get; init; }
    public Tag Tag { get; init; } = null!;
}

internal sealed class FilterListTagTypeConfiguration : IEntityTypeConfiguration<FilterListTag>
{
    public void Configure(EntityTypeBuilder<FilterListTag> builder)
    {
        builder.HasKey(flt => new { flt.FilterListId, flt.TagId });
        builder.HasDataJsonFile<FilterListTag>();
    }
}