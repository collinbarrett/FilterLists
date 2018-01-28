using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class FilterListLanguageTypeConfiguration : JunctionBaseTypeConfiguration<FilterListLanguage>
    {
        public override void Configure(EntityTypeBuilder<FilterListLanguage> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("filterlists_languages");
            entityTypeBuilder.HasKey(x => new {x.FilterListId, x.LanguageId});
        }
    }
}