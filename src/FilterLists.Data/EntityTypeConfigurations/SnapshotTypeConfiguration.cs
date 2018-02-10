using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class SnapshotTypeConfiguration : BaseEntityTypeConfiguration<Snapshot>
    {
        public override void Configure(EntityTypeBuilder<Snapshot> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("snapshots");
            entityTypeBuilder.Property(x => x.Id)
                             .HasColumnType("MEDIUMINT UNSIGNED");
            entityTypeBuilder.Property(x => x.HttpStatusCode)
                             .HasColumnType("VARCHAR(3)")
                             .HasDefaultValueSql("NULL");
        }
    }
}