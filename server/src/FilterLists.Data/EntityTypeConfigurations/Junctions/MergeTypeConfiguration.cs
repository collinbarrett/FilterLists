using Ardalis.GuardClauses;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class MergeTypeConfiguration : BaseJunctionTypeConfiguration<Merge>
    {
        public override void Configure(EntityTypeBuilder<Merge> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("merges");
            builder.HasKey(x => new {x.MergeFilterListId, x.UpstreamFilterListId});
            builder.HasOne(x => x.MergeFilterList)
                .WithMany(x => x.MergeFilterLists)
                .HasForeignKey(x => x.MergeFilterListId);
            builder.HasOne(x => x.UpstreamFilterList)
                .WithMany(x => x.UpstreamMergeFilterLists)
                .HasForeignKey(x => x.UpstreamFilterListId);
        }
    }
}