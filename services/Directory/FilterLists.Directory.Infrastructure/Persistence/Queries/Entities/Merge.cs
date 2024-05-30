using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Merge
{
    public long IncludedInFilterListId { get; init; }
    public FilterList IncludedInFilterList { get; init; } = default!;
    public long IncludesFilterListId { get; init; }
    public FilterList IncludesFilterList { get; init; } = default!;
}

internal class MergeTypeConfiguration : IEntityTypeConfiguration<Merge>
{
    public virtual void Configure(EntityTypeBuilder<Merge> builder)
    {
        builder.HasKey(m => new { m.IncludedInFilterListId, m.IncludesFilterListId });
        builder.HasOne(m => m.IncludedInFilterList)
            .WithMany(fl => fl.IncludesFilterLists)
            .HasForeignKey(m => m.IncludedInFilterListId);
        builder.HasOne(m => m.IncludesFilterList)
            .WithMany(fl => fl.IncludedInFilterLists)
            .HasForeignKey(m => m.IncludesFilterListId);
        builder.HasDataJsonFile<Merge>();
    }
}