using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class LanguageTypeConfiguration : BaseEntityTypeConfiguration<Language>
    {
        public override void Configure(EntityTypeBuilder<Language> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("languages");

            entityTypeBuilder.Property(b => b.Iso6391)
                .HasMaxLength(2);

            entityTypeBuilder.Property(b => b.Iso6392)
                .HasMaxLength(3);

            entityTypeBuilder.Property(b => b.Iso6392B)
                .HasMaxLength(3);

            entityTypeBuilder.Property(b => b.Iso6392T)
                .HasMaxLength(3);

            entityTypeBuilder.Property(b => b.Iso6393)
                .HasMaxLength(3);

            entityTypeBuilder.Property(b => b.LocalName)
                .HasMaxLength(126);

            entityTypeBuilder.Property(b => b.Name)
                .HasMaxLength(126);

            base.Configure(entityTypeBuilder);
        }
    }
}