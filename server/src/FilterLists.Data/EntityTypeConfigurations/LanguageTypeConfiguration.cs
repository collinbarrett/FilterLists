using Ardalis.GuardClauses;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class LanguageTypeConfiguration : BaseEntityTypeConfiguration<Language>
    {
        public override void Configure(EntityTypeBuilder<Language> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("languages");
            builder.Property(x => x.Iso6391)
                .HasColumnType("VARCHAR(2)")
                .HasDefaultValueSql("NULL");
            builder.Property(x => x.Iso6392)
                .HasColumnType("VARCHAR(3)")
                .HasDefaultValueSql("NULL");
            builder.Property(x => x.Iso6392B)
                .HasColumnType("VARCHAR(3)")
                .HasDefaultValueSql("NULL");
            builder.Property(x => x.Iso6392T)
                .HasColumnType("VARCHAR(3)")
                .HasDefaultValueSql("NULL");
            builder.Property(x => x.Iso6393)
                .HasColumnType("VARCHAR(3)")
                .HasDefaultValueSql("NULL");
            builder.Property(x => x.LocalName)
                .HasColumnType("VARCHAR(126)")
                .HasDefaultValueSql("NULL");
            builder.Property(x => x.Name)
                .HasColumnType("VARCHAR(126)")
                .HasDefaultValueSql("NULL");
        }
    }
}