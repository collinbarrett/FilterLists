using Ardalis.GuardClauses;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class DependentTypeConfiguration : BaseJunctionTypeConfiguration<Dependent>
    {
        public override void Configure(EntityTypeBuilder<Dependent> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("dependents");
            builder.HasKey(x => new {x.DependentFilterListId, x.DependencyFilterListId});
            builder.HasOne(x => x.DependentFilterList)
                .WithMany(x => x.DependentFilterLists)
                .HasForeignKey(x => x.DependentFilterListId);
            builder.HasOne(x => x.DependencyFilterList)
                .WithMany(x => x.DependencyFilterLists)
                .HasForeignKey(x => x.DependencyFilterListId);
        }
    }
}