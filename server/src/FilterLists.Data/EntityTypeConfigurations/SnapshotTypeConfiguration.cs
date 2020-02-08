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
                             .HasColumnType("MEDIUMINT");
            entityTypeBuilder.Property(x => x.HttpStatusCode)
                             .HasColumnType("SMALLINT")
                             .HasDefaultValueSql("NULL");
            entityTypeBuilder.Property(x => x.Md5Checksum)
                             .HasColumnType("BINARY(16)");
            entityTypeBuilder.Property(x => x.WaybackTimestamp)
                             .HasColumnType("TIMESTAMP");
            entityTypeBuilder.Property(x => x.WaybackUrl)
                             .HasColumnType("TEXT");
        }
    }
}