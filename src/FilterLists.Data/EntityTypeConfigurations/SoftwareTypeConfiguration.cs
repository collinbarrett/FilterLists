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
            entityTypeBuilder.Property(x => x.ModifiedDateUtc)
                .HasColumnType("TIMESTAMP")
                .ValueGeneratedOnAddOrUpdate();
            entityTypeBuilder.Property(x => x.DownloadUrl)
                .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.HomeUrl)
                .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.Name)
                .HasColumnType("NVARCHAR(126)")
                .IsRequired();
            base.Configure(entityTypeBuilder);
        }
    }
}