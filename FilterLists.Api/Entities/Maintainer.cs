using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Entities;

public record Maintainer
{
    public int Id { get; private init; }
    public string Name { get; private init; } = default!;
    public Uri? Url { get; private init; }
    public string? EmailAddress { get; private init; }
    public string? TwitterHandle { get; private init; }

    public IEnumerable<FilterListMaintainer> FilterListMaintainers { get; private init; } =
        new HashSet<FilterListMaintainer>();
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