using Ardalis.GuardClauses;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class SnapshotRuleTypeConfiguration : BaseJunctionTypeConfiguration<SnapshotRule>
    {
        public override void Configure(EntityTypeBuilder<SnapshotRule> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("snapshots_rules");
            builder.HasKey(x => new {x.SnapshotId, x.RuleId});
            builder.Ignore(x => x.CreatedDateUtc);
            builder.HasOne(x => x.Snapshot)
                .WithMany(x => x.SnapshotRules)
                .HasForeignKey(x => x.SnapshotId);
            builder.HasOne(x => x.Rule)
                .WithMany(x => x.SnapshotRules)
                .HasForeignKey(x => x.RuleId);
        }
    }
}