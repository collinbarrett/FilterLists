using Ardalis.GuardClauses;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class MaintainerTypeConfiguration : BaseEntityTypeConfiguration<Maintainer>
    {
        public override void Configure(EntityTypeBuilder<Maintainer> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("maintainers");
            builder.Property(x => x.EmailAddress)
                .HasColumnType("VARCHAR(126)")
                .HasDefaultValueSql("NULL");
            builder.Property(x => x.HomeUrl)
                .HasColumnType("TEXT");
            builder.Property(x => x.Name)
                .HasColumnType("VARCHAR(126)")
                .IsRequired();
            builder.Property(x => x.TwitterHandle)
                .HasColumnType("VARCHAR(126)")
                .HasDefaultValueSql("NULL");
        }
    }
}