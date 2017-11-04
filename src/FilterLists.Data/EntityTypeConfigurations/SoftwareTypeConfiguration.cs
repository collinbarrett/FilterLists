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
            entityTypeBuilder.Property(x => x.DownloadUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(x => x.HomeUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(x => x.Name)
                .HasMaxLength(126);
            base.Configure(entityTypeBuilder);
        }
    }
}