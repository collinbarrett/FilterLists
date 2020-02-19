using Ardalis.GuardClauses;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class LicenseTypeConfiguration : BaseEntityTypeConfiguration<License>
    {
        public override void Configure(EntityTypeBuilder<License> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("licenses");
            builder.Property(x => x.DescriptionUrl)
                .HasColumnType("TEXT");
            builder.Property(x => x.Name)
                .HasColumnType("VARCHAR(126)")
                .IsRequired();
        }
    }
}