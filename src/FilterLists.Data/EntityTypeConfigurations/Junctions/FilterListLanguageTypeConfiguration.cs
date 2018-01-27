using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class FilterListLanguageTypeConfiguration : IEntityTypeConfiguration<FilterListLanguage>
    {
        public void Configure(EntityTypeBuilder<FilterListLanguage> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("filterlists_languages");
            entityTypeBuilder.HasKey(x => new {x.FilterListId, x.LanguageId});
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");
        }
    }
}