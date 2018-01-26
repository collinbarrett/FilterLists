using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class SnapshotTypeConfiguration : BaseEntityTypeConfiguration<Snapshot>
    {
        public override void Configure(EntityTypeBuilder<Snapshot> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("snapshots");
            entityTypeBuilder.Property(x => x.Content)
                .HasColumnType("MEDIUMTEXT")
                .IsRequired();
            entityTypeBuilder.Ignore(x => x.ModifiedDateUtc);
            base.Configure(entityTypeBuilder);
        }
    }
}