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
            entityTypeBuilder.Property(x => x.Iso6391)
                .HasMaxLength(2);
            entityTypeBuilder.Property(x => x.Iso6392)
                .HasMaxLength(3);
            entityTypeBuilder.Property(x => x.Iso6392B)
                .HasMaxLength(3);
            entityTypeBuilder.Property(x => x.Iso6392T)
                .HasMaxLength(3);
            entityTypeBuilder.Property(x => x.Iso6393)
                .HasMaxLength(3);
            entityTypeBuilder.Property(x => x.LocalName)
                .HasMaxLength(126);
            entityTypeBuilder.Property(x => x.Name)
                .HasMaxLength(126);
            base.Configure(entityTypeBuilder);
        }
    }
}