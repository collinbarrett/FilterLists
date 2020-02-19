using Ardalis.GuardClauses;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class FilterListMaintainerTypeConfiguration : BaseJunctionTypeConfiguration<FilterListMaintainer>
    {
        public override void Configure(EntityTypeBuilder<FilterListMaintainer> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("filterlists_maintainers");
            builder.HasKey(x => new {x.FilterListId, x.MaintainerId});
            builder.HasOne(x => x.FilterList)
                .WithMany(x => x.FilterListMaintainers)
                .HasForeignKey(x => x.FilterListId);
            builder.HasOne(x => x.Maintainer)
                .WithMany(x => x.FilterListMaintainers)
                .HasForeignKey(x => x.MaintainerId);
        }
    }
}