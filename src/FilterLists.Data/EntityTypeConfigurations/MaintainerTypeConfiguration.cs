using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class MaintainerTypeConfiguration : BaseEntityTypeConfiguration<Maintainer>
    {
        public override void Configure(EntityTypeBuilder<Maintainer> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("maintainers");
            entityTypeBuilder.Property(x => x.EmailAddress)
                .HasMaxLength(126);
            entityTypeBuilder.Property(x => x.HomeUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(126);
            entityTypeBuilder.Property(x => x.TwitterHandle)
                .HasMaxLength(126);
            base.Configure(entityTypeBuilder);
        }
    }
}