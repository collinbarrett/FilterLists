using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class SnapshotRuleTypeConfiguration : BaseJunctionTypeConfiguration<SnapshotRule>
    {
        public override void Configure(EntityTypeBuilder<SnapshotRule> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("snapshots_rules");
            entityTypeBuilder.HasKey(x => new {x.AddedBySnapshotId, x.RuleId});
            entityTypeBuilder.Property(x => x.ModifiedDateUtc)
                             .HasColumnType("TIMESTAMP")
                             .ValueGeneratedOnAddOrUpdate();
            entityTypeBuilder.HasOne(x => x.AddedBySnapshot)
                             .WithMany(x => x.AddedSnapshotRules)
                             .HasForeignKey(x => x.AddedBySnapshotId);
            entityTypeBuilder.HasOne(x => x.RemovedBySnapshot)
                             .WithMany(x => x.RemovedSnapshotRules)
                             .HasForeignKey(x => x.RemovedBySnapshotId)
                             .OnDelete(DeleteBehavior.Cascade);
            entityTypeBuilder.HasOne(x => x.Rule)
                             .WithMany(x => x.SnapshotRules)
                             .HasForeignKey(x => x.RuleId);
        }
    }
}