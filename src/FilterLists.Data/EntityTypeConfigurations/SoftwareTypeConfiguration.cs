using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class SoftwareTypeConfiguration : IEntityTypeConfiguration<Software>
    {
        public void Configure(EntityTypeBuilder<Software> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("software");

            entityTypeBuilder.Property(x => x.Id)
                .HasColumnType("SMALLINT UNSIGNED");
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                .HasColumnType("TIMESTAMP")
                .ValueGeneratedOnAdd();
            entityTypeBuilder.Property(x => x.ModifiedDateUtc)
                .HasColumnType("TIMESTAMP")
                .ValueGeneratedOnAddOrUpdate();

            entityTypeBuilder.Property(x => x.DownloadUrl)
                .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.HomeUrl)
                .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.Name)
                .HasColumnType("NVARCHAR(126) NOT NULL");
        }
    }
}