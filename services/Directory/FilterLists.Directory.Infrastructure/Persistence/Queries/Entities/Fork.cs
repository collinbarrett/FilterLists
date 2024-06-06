using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record Fork
{
    public int UpstreamFilterListId { get; init; }
    public FilterList UpstreamFilterList { get; init; } = null!;
    public int ForkFilterListId { get; init; }
    public FilterList ForkFilterList { get; init; } = null!;
}

internal sealed class ForkTypeConfiguration : IEntityTypeConfiguration<Fork>
{
    public void Configure(EntityTypeBuilder<Fork> builder)
    {
        builder.HasKey(f => new { f.UpstreamFilterListId, f.ForkFilterListId });
        builder.HasOne(f => f.UpstreamFilterList)
            .WithMany(fl => fl.ForkFilterLists)
            .HasForeignKey(f => f.UpstreamFilterListId);
        builder.HasOne(f => f.ForkFilterList)
            .WithMany(fl => fl.UpstreamFilterLists)
            .HasForeignKey(f => f.ForkFilterListId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasDataJsonFile<Fork>();
    }
}