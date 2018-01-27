using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class MergeTypeConfiguration : IEntityTypeConfiguration<Merge>
    {
        public void Configure(EntityTypeBuilder<Merge> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("merges");
            entityTypeBuilder.HasKey(x => new {x.MergeFilterListId, x.UpstreamFilterListId});
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");
        }
    }
}