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
        }
    }
}