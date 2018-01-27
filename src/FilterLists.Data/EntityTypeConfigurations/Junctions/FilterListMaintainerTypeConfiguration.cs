using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class FilterListMaintainerTypeConfiguration : IEntityTypeConfiguration<FilterListMaintainer>
    {
        public void Configure(EntityTypeBuilder<FilterListMaintainer> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("filterlists_maintainers");
            entityTypeBuilder.HasKey(x => new {x.FilterListId, x.MaintainerId});
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");
        }
    }
}