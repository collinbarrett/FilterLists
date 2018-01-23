using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class ForkTypeConfiguration : BaseEntityTypeConfiguration<Fork>
    {
        public override void Configure(EntityTypeBuilder<Fork> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("forks");
            entityTypeBuilder.HasKey(x => new {x.ForkFilterListId, x.UpstreamFilterListId});
            entityTypeBuilder.Ignore(x => x.Id);
            base.Configure(entityTypeBuilder);
        }
    }
}