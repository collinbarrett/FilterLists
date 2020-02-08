using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class DependentTypeConfiguration : BaseJunctionTypeConfiguration<Dependent>
    {
        public override void Configure(EntityTypeBuilder<Dependent> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("dependents");
            entityTypeBuilder.HasKey(x => new {x.DependentFilterListId, x.DependencyFilterListId});
            entityTypeBuilder.HasOne(x => x.DependentFilterList)
                             .WithMany(x => x.DependentFilterLists)
                             .HasForeignKey(x => x.DependentFilterListId);
            entityTypeBuilder.HasOne(x => x.DependencyFilterList)
                             .WithMany(x => x.DependencyFilterLists)
                             .HasForeignKey(x => x.DependencyFilterListId);
        }
    }
}