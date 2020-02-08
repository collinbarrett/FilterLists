using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class LanguageTypeConfiguration : BaseEntityTypeConfiguration<Language>
    {
        public override void Configure(EntityTypeBuilder<Language> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("languages");
            entityTypeBuilder.Property(x => x.Iso6391)
                             .HasColumnType("VARCHAR(2)")
                             .HasDefaultValueSql("NULL");
            entityTypeBuilder.Property(x => x.Iso6392)
                             .HasColumnType("VARCHAR(3)")
                             .HasDefaultValueSql("NULL");
            entityTypeBuilder.Property(x => x.Iso6392B)
                             .HasColumnType("VARCHAR(3)")
                             .HasDefaultValueSql("NULL");
            entityTypeBuilder.Property(x => x.Iso6392T)
                             .HasColumnType("VARCHAR(3)")
                             .HasDefaultValueSql("NULL");
            entityTypeBuilder.Property(x => x.Iso6393)
                             .HasColumnType("VARCHAR(3)")
                             .HasDefaultValueSql("NULL");
            entityTypeBuilder.Property(x => x.LocalName)
                             .HasColumnType("VARCHAR(126)")
                             .HasDefaultValueSql("NULL");
            entityTypeBuilder.Property(x => x.Name)
                             .HasColumnType("VARCHAR(126)")
                             .HasDefaultValueSql("NULL");
        }
    }
}