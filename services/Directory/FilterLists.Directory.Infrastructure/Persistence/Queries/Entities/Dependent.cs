using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record Dependent
{
    public int DependencyFilterListId { get; init; }
    public FilterList DependencyFilterList { get; init; } = null!;
    public int DependentFilterListId { get; init; }
    public FilterList DependentFilterList { get; init; } = null!;
}

internal sealed class DependentTypeConfiguration : IEntityTypeConfiguration<Dependent>
{
    public void Configure(EntityTypeBuilder<Dependent> builder)
    {
        builder.HasKey(d => new { d.DependencyFilterListId, d.DependentFilterListId });
        builder.HasOne(d => d.DependencyFilterList)
            .WithMany(fl => fl.DependentFilterLists)
            .HasForeignKey(d => d.DependencyFilterListId);
        builder.HasOne(d => d.DependentFilterList)
            .WithMany(fl => fl.DependencyFilterLists)
            .HasForeignKey(d => d.DependentFilterListId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasDataJsonFile<Dependent>();
    }
}