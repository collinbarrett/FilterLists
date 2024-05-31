using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterListTag
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = null!;
    public int TagId { get; init; }
    public Tag Tag { get; init; } = null!;
}

internal class FilterListTagTypeConfiguration : IEntityTypeConfiguration<FilterListTag>
{
    public virtual void Configure(EntityTypeBuilder<FilterListTag> builder)
    {
        builder.HasKey(flt => new { flt.FilterListId, flt.TagId });
        builder.HasDataJsonFile<FilterListTag>();
    }
}