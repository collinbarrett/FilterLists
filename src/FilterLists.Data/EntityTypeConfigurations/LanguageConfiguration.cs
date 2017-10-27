using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> entityTypeBuilder)
        {
            entityTypeBuilder.Property(b => b.CreatedDateUtc).HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}