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
                .IsUnicode()
                .HasMaxLength(2);
            entityTypeBuilder.Property(x => x.Iso6392)
                .IsUnicode()
                .HasMaxLength(3);
            entityTypeBuilder.Property(x => x.Iso6392B)
                .IsUnicode()
                .HasMaxLength(3);
            entityTypeBuilder.Property(x => x.Iso6392T)
                .IsUnicode()
                .HasMaxLength(3);
            entityTypeBuilder.Property(x => x.Iso6393)
                .IsUnicode()
                .HasMaxLength(3);
            entityTypeBuilder.Property(x => x.LocalName)
                .IsUnicode()
                .HasMaxLength(126);
            entityTypeBuilder.Property(x => x.Name)
                .IsUnicode()
                .HasMaxLength(126);
            base.Configure(entityTypeBuilder);
        }
    }
}