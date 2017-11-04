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
            entityTypeBuilder.Property(x => x.DescriptionUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(126);
            base.Configure(entityTypeBuilder);
        }
    }
}