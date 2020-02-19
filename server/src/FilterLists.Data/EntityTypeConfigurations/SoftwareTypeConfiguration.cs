using Ardalis.GuardClauses;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class SoftwareTypeConfiguration : BaseEntityTypeConfiguration<Software>
    {
        public override void Configure(EntityTypeBuilder<Software> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("software");
            builder.Property(x => x.DownloadUrl)
                .HasColumnType("TEXT");
            builder.Property(x => x.HomeUrl)
                .HasColumnType("TEXT");
            builder.Property(x => x.Name)
                .HasColumnType("VARCHAR(126)")
                .IsRequired();
        }
    }
}