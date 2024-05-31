using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Fork
{
    public int UpstreamFilterListId { get; init; }
    public required FilterList UpstreamFilterList { get; init; }
    public int ForkFilterListId { get; init; }
    public required FilterList ForkFilterList { get; init; }
}

internal class ForkTypeConfiguration : IEntityTypeConfiguration<Fork>
{
    public virtual void Configure(EntityTypeBuilder<Fork> builder)
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