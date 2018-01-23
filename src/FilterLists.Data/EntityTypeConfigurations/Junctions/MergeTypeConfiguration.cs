using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class MergeTypeConfiguration : BaseEntityTypeConfiguration<Merge>
    {
        public override void Configure(EntityTypeBuilder<Merge> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("merges");
            entityTypeBuilder.HasKey(x => new {x.MergeFilterListId, x.UpstreamFilterListId});
            entityTypeBuilder.Ignore(x => x.Id);
            base.Configure(entityTypeBuilder);
        }
    }
}