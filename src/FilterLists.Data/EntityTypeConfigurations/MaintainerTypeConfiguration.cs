using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class MaintainerTypeConfiguration : IEntityTypeConfiguration<Maintainer>
    {
        public void Configure(EntityTypeBuilder<Maintainer> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("maintainers");

            entityTypeBuilder.Property(x => x.Id)
                .HasColumnType("SMALLINT UNSIGNED");
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");
            entityTypeBuilder.Property(x => x.ModifiedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

            entityTypeBuilder.Property(x => x.EmailAddress)
                .HasColumnType("NVARCHAR(126)");
            entityTypeBuilder.Property(x => x.HomeUrl)
                .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.Name)
                .HasColumnType("NVARCHAR(126) NOT NULL");
            entityTypeBuilder.Property(x => x.TwitterHandle)
                .HasColumnType("NVARCHAR(126)");
        }
    }
}