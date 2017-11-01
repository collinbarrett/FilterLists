using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class LicenseTypeConfiguration : BaseEntityTypeConfiguration<License>
    {
        public override void Configure(EntityTypeBuilder<License> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("licenses");
            entityTypeBuilder.Property(b => b.DescriptionUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(126);
            base.Configure(entityTypeBuilder);
        }
    }
}