using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record Merge
{
    public int IncludedInFilterListId { get; init; }
    public FilterList IncludedInFilterList { get; init; } = null!;
    public int IncludesFilterListId { get; init; }
    public FilterList IncludesFilterList { get; init; } = null!;
}

internal sealed class MergeTypeConfiguration : IEntityTypeConfiguration<Merge>
{
    public void Configure(EntityTypeBuilder<Merge> builder)
    {
        builder.HasKey(m => new { m.IncludedInFilterListId, m.IncludesFilterListId });
        builder.HasOne(m => m.IncludedInFilterList)
            .WithMany(fl => fl.IncludesFilterLists)
            .HasForeignKey(m => m.IncludedInFilterListId);
        builder.HasOne(m => m.IncludesFilterList)
            .WithMany(fl => fl.IncludedInFilterLists)
            .HasForeignKey(m => m.IncludesFilterListId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasDataJsonFile<Merge>();
    }
}