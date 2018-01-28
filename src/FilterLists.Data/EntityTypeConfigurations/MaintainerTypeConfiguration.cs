using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class MaintainerTypeConfiguration : BaseEntityTypeConfiguration<Maintainer>
    {
        public override void Configure(EntityTypeBuilder<Maintainer> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);

            entityTypeBuilder.ToTable("maintainers");

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