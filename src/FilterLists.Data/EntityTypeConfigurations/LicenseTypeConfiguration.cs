using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class LicenseTypeConfiguration : BaseEntityTypeConfiguration<License>
    {
        public override void Configure(EntityTypeBuilder<License> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("licenses");
            entityTypeBuilder.Property(x => x.DescriptionUrl)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.Name)
                             .HasColumnType("VARCHAR(126)")
                             .IsRequired();
        }
    }
}