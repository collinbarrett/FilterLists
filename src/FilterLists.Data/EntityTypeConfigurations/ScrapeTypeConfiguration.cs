using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class ScrapeTypeConfiguration : BaseEntityTypeConfiguration<Scrape>
    {
        public override void Configure(EntityTypeBuilder<Scrape> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);

            entityTypeBuilder.ToTable("scrapes");

            entityTypeBuilder.Ignore(x => x.ModifiedDateUtc);
        }
    }
}