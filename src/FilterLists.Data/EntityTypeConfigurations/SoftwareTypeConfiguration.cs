using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class SoftwareTypeConfiguration : BaseEntityTypeConfiguration<Software>
    {
        public override void Configure(EntityTypeBuilder<Software> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("software");
            entityTypeBuilder.Property(b => b.DownloadUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(b => b.HomeUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(b => b.Name)
                .HasMaxLength(126);
            base.Configure(entityTypeBuilder);
        }
    }
}