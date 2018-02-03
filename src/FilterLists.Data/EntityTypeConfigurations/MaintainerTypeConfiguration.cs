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
                             .HasColumnType("VARCHAR(126)")
                             .HasDefaultValueSql("NULL");
            entityTypeBuilder.Property(x => x.HomeUrl)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.Name)
                             .HasColumnType("VARCHAR(126)")
                             .IsRequired();
            entityTypeBuilder.Property(x => x.TwitterHandle)
                             .HasColumnType("VARCHAR(126)")
                             .HasDefaultValueSql("NULL");
        }
    }
}