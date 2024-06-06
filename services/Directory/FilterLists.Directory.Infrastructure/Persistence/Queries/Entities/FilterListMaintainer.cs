using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record FilterListMaintainer
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = null!;
    public int MaintainerId { get; init; }
    public Maintainer Maintainer { get; init; } = null!;
}

internal sealed class FilterListMaintainerTypeConfiguration : IEntityTypeConfiguration<FilterListMaintainer>
{
    public void Configure(EntityTypeBuilder<FilterListMaintainer> builder)
    {
        builder.HasKey(flm => new { flm.FilterListId, flm.MaintainerId });
        builder.HasDataJsonFile<FilterListMaintainer>();
    }
}