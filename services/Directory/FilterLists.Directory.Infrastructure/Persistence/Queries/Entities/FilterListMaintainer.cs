using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterListMaintainer
{
    public int FilterListId { get; init; }
    public required FilterList FilterList { get; init; }
    public int MaintainerId { get; init; }
    public required Maintainer Maintainer { get; init; }
}

internal class FilterListMaintainerTypeConfiguration : IEntityTypeConfiguration<FilterListMaintainer>
{
    public virtual void Configure(EntityTypeBuilder<FilterListMaintainer> builder)
    {
        builder.HasKey(flm => new { flm.FilterListId, flm.MaintainerId });
        builder.HasDataJsonFile<FilterListMaintainer>();
    }
}