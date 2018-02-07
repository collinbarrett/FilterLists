using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class FilterListMaintainerTypeConfiguration : BaseJunctionTypeConfiguration<FilterListMaintainer>
    {
        public override void Configure(EntityTypeBuilder<FilterListMaintainer> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("filterlists_maintainers");
            entityTypeBuilder.HasKey(x => new {x.FilterListId, x.MaintainerId});
            entityTypeBuilder.HasOne(x => x.FilterList)
                             .WithMany(x => x.FilterListMaintainers)
                             .HasForeignKey(x => x.FilterListId);
            entityTypeBuilder.HasOne(x => x.Maintainer)
                             .WithMany(x => x.FilterListMaintainers)
                             .HasForeignKey(x => x.MaintainerId);
        }
    }
}