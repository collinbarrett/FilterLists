using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Merge
{
    public int IncludedInFilterListId { get; init; }
    public required FilterList IncludedInFilterList { get; init; }
    public int IncludesFilterListId { get; init; }
    public required FilterList IncludesFilterList { get; init; }
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
            .HasForeignKey(m => m.IncludesFilterListId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasDataJsonFile<Merge>();
    }
}