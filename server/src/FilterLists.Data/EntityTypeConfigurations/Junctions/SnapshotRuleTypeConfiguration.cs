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
            entityTypeBuilder.HasKey(x => new {x.SnapshotId, x.RuleId});
            entityTypeBuilder.Ignore(x => x.CreatedDateUtc);
            entityTypeBuilder.HasOne(x => x.Snapshot)
                             .WithMany(x => x.SnapshotRules)
                             .HasForeignKey(x => x.SnapshotId);
            entityTypeBuilder.HasOne(x => x.Rule)
                             .WithMany(x => x.SnapshotRules)
                             .HasForeignKey(x => x.RuleId);
        }
    }
}