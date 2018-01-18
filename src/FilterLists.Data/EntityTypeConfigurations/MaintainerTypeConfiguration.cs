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
                .IsUnicode()
                .HasMaxLength(126);
            entityTypeBuilder.Property(x => x.HomeUrl)
                .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.Name)
                .IsUnicode()
                .IsRequired()
                .HasMaxLength(126);
            entityTypeBuilder.Property(x => x.TwitterHandle)
                .IsUnicode()
                .HasMaxLength(126);
            base.Configure(entityTypeBuilder);
        }
    }
}