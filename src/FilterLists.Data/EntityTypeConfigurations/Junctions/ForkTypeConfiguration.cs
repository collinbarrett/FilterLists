using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class ForkTypeConfiguration : BaseJunctionTypeConfiguration<Fork>
    {
        public override void Configure(EntityTypeBuilder<Fork> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("forks");
            entityTypeBuilder.HasKey(x => new {x.ForkFilterListId, x.UpstreamFilterListId});
        }
    }
}