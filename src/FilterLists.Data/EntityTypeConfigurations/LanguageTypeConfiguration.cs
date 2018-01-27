using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class LanguageTypeConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("languages");

            entityTypeBuilder.Property(x => x.Id)
                .HasColumnType("SMALLINT UNSIGNED");
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");
            entityTypeBuilder.Property(x => x.ModifiedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

            entityTypeBuilder.Property(x => x.Iso6391)
                .HasColumnType("NVARCHAR(2)");
            entityTypeBuilder.Property(x => x.Iso6392)
                .HasColumnType("NVARCHAR(3)");
            entityTypeBuilder.Property(x => x.Iso6392B)
                .HasColumnType("NVARCHAR(3)");
            entityTypeBuilder.Property(x => x.Iso6392T)
                .HasColumnType("NVARCHAR(3)");
            entityTypeBuilder.Property(x => x.Iso6393)
                .HasColumnType("NVARCHAR(3)");
            entityTypeBuilder.Property(x => x.LocalName)
                .HasColumnType("NVARCHAR(126)");
            entityTypeBuilder.Property(x => x.Name)
                .HasColumnType("NVARCHAR(126)");
        }
    }
}