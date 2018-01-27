using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class LicenseTypeConfiguration : IEntityTypeConfiguration<License>
    {
        public void Configure(EntityTypeBuilder<License> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("licenses");

            entityTypeBuilder.Property(x => x.Id)
                .HasColumnType("SMALLINT UNSIGNED");
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");
            entityTypeBuilder.Property(x => x.ModifiedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

            entityTypeBuilder.Property(x => x.DescriptionUrl)
                .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.Name)
                .HasColumnType("NVARCHAR(126) NOT NULL");
        }
    }
}