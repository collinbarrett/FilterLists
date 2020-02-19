using Ardalis.GuardClauses;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class ForkTypeConfiguration : BaseJunctionTypeConfiguration<Fork>
    {
        public override void Configure(EntityTypeBuilder<Fork> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("forks");
            builder.HasKey(x => new {x.ForkFilterListId, x.UpstreamFilterListId});
            builder.HasOne(x => x.ForkFilterList)
                .WithMany(x => x.ForkFilterLists)
                .HasForeignKey(x => x.ForkFilterListId);
            builder.HasOne(x => x.UpstreamFilterList)
                .WithMany(x => x.UpstreamForkFilterLists)
                .HasForeignKey(x => x.UpstreamFilterListId);
        }
    }
}