using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

public record Merge
{
    public int IncludedInFilterListId { get; init; }
    public FilterList IncludedInFilterList { get; init; } = new();
    public int IncludesFilterListId { get; init; }
    public FilterList IncludesFilterList { get; init; } = new();
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
            .OnDelete(DeleteBehavior
                .ClientSetNull); // https://github.com/dotnet/efcore/issues/12581#issuecomment-403080615;
        builder.HasDataJsonFile<Merge>();
    }
}