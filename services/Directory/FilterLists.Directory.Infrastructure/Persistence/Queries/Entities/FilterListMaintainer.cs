using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListMaintainer
    {
        public int FilterListId { get; private set; }
        public FilterList FilterList { get; } = null!;
        public int MaintainerId { get; private set; }
        public Maintainer Maintainer { get; } = null!;
    }

    internal class FilterListMaintainerTypeConfiguration : IEntityTypeConfiguration<FilterListMaintainer>
    {
        public virtual void Configure(EntityTypeBuilder<FilterListMaintainer> builder)
        {
            builder.ToTable(nameof(FilterListMaintainer) + "s");
            builder.HasKey(flm => new { flm.FilterListId, flm.MaintainerId });
            builder.HasDataJsonFile<FilterListMaintainer>();
        }
    }
}
