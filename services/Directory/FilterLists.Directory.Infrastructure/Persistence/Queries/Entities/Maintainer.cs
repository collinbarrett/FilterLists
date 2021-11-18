using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Maintainer
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public Uri? Url { get; init; }
    public string? EmailAddress { get; init; }
    public string? TwitterHandle { get; init; }
    public IReadOnlyCollection<FilterListMaintainer> FilterListMaintainers { get; } = new HashSet<FilterListMaintainer>();
}

internal class MaintainerTypeConfiguration : IEntityTypeConfiguration<Maintainer>
{
    public virtual void Configure(EntityTypeBuilder<Maintainer> builder)
    {
        builder.HasIndex(m => m.Name)
            .IsUnique();
        builder.HasDataJsonFile<Maintainer>();
    }
}
