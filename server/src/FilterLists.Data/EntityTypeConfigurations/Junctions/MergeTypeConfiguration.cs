using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class MergeTypeConfiguration : BaseJunctionTypeConfiguration<Merge>
    {
        public override void Configure(EntityTypeBuilder<Merge> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("merges");
            entityTypeBuilder.HasKey(x => new {x.MergeFilterListId, x.UpstreamFilterListId});
            entityTypeBuilder.HasOne(x => x.MergeFilterList)
                             .WithMany(x => x.MergeFilterLists)
                             .HasForeignKey(x => x.MergeFilterListId);
            entityTypeBuilder.HasOne(x => x.UpstreamFilterList)
                             .WithMany(x => x.UpstreamMergeFilterLists)
                             .HasForeignKey(x => x.UpstreamFilterListId);
        }
    }
}