using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

public record FilterListTag
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = new();
    public int TagId { get; init; }
    public Tag Tag { get; init; } = new();
}

internal class FilterListTagTypeConfiguration : IEntityTypeConfiguration<FilterListTag>
{
    public virtual void Configure(EntityTypeBuilder<FilterListTag> builder)
    {
        builder.HasKey(flt => new { flt.FilterListId, flt.TagId });
        builder.HasDataJsonFile<FilterListTag>();
    }
}