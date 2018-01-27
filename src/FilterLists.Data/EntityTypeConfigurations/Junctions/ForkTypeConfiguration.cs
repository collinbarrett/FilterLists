using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class ForkTypeConfiguration : IEntityTypeConfiguration<Fork>
    {
        public void Configure(EntityTypeBuilder<Fork> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("forks");
            entityTypeBuilder.HasKey(x => new {x.ForkFilterListId, x.UpstreamFilterListId});
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");
        }
    }
}