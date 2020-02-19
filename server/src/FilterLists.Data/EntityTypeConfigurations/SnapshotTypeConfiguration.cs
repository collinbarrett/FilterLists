using Ardalis.GuardClauses;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class SnapshotTypeConfiguration : BaseEntityTypeConfiguration<Snapshot>
    {
        public override void Configure(EntityTypeBuilder<Snapshot> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("snapshots");
            builder.Property(x => x.Id)
                .HasColumnType("MEDIUMINT");
            builder.Property(x => x.HttpStatusCode)
                .HasColumnType("SMALLINT")
                .HasDefaultValueSql("NULL");
            builder.Property(x => x.Md5Checksum)
                .HasColumnType("BINARY(16)");
            builder.Property(x => x.WaybackTimestamp)
                .HasColumnType("TIMESTAMP");
            builder.Property(x => x.WaybackUrl)
                .HasColumnType("TEXT");
        }
    }
}