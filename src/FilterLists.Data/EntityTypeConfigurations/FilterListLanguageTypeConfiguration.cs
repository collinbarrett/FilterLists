using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class FilterListLanguageTypeConfiguration : BaseEntityTypeConfiguration<FilterListLanguage>
    {
        public override void Configure(EntityTypeBuilder<FilterListLanguage> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("filterlists_languages");
            entityTypeBuilder.HasKey(x => new {x.FilterListId, x.LanguageId});
            entityTypeBuilder.Ignore(x => x.Id);
            base.Configure(entityTypeBuilder);
        }
    }
}