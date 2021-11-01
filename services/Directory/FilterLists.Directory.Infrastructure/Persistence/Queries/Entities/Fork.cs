using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Fork
    {
        public int UpstreamFilterListId { get; set; }
        public FilterList UpstreamFilterList { get; } = null!;
        public int ForkFilterListId { get; set; }
        public FilterList ForkFilterList { get; } = null!;
    }

    internal class ForkTypeConfiguration : IEntityTypeConfiguration<Fork>
    {
        public virtual void Configure(EntityTypeBuilder<Fork> builder)
        {
            builder.ToTable(nameof(Fork) + "s");
            builder.HasKey(f => new { f.UpstreamFilterListId, f.ForkFilterListId });
            builder.HasOne(f => f.UpstreamFilterList)
                .WithMany(fl => fl.ForkFilterLists)
                .HasForeignKey(f => f.UpstreamFilterListId);
            builder.HasOne(f => f.ForkFilterList)
                .WithMany(fl => fl.UpstreamFilterLists)
                .HasForeignKey(f => f.ForkFilterListId);
            builder.HasDataJsonFile<Fork>();
        }
    }
}
