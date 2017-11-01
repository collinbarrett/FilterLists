using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class ForkTypeConfiguration : BaseEntityTypeConfiguration<Fork>
    {
        public override void Configure(EntityTypeBuilder<Fork> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("forks");
            entityTypeBuilder.HasKey(x => new {x.ForkFilterListId, x.UpstreamFilterListId});
            //https://stackoverflow.com/questions/47053627/configure-foreign-keys-to-the-same-entity-in-junction-entity-via-fluent-api-in-i
            //TODO: Configure foreign key mapping from ForkFilterListId to FilterList.Id
            //TODO: Configure foreign key mapping from UpstreamFilterListId to FilterList.Id
            entityTypeBuilder.Ignore(x => x.Id);
            base.Configure(entityTypeBuilder);
        }
    }
}