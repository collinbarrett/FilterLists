using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class MaintainerTypeConfiguration : BaseEntityTypeConfiguration<Maintainer>
    {
        public override void Configure(EntityTypeBuilder<Maintainer> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Maintainers");

            entityTypeBuilder.Property(b => b.Email)
                .HasMaxLength(126);

            entityTypeBuilder.Property(b => b.HomeUrl)
                .HasMaxLength(2083);

            entityTypeBuilder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(126);

            entityTypeBuilder.Property(b => b.TwitterHandle)
                .HasMaxLength(126);

            base.Configure(entityTypeBuilder);
        }
    }
}