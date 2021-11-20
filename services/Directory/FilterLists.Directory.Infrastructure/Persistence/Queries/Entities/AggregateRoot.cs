using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public abstract record AggregateRoot
{
    // TODO: change 'set' to 'private init' when no longer seeding from json
    public bool IsApproved { get; set; }
}

internal abstract class AggregateRootTypeConfiguration<TAggregateRoot> : IEntityTypeConfiguration<TAggregateRoot>
    where TAggregateRoot : AggregateRoot
{
    public virtual void Configure(EntityTypeBuilder<TAggregateRoot> builder)
    {
        builder.HasQueryFilter(e => e.IsApproved);
    }
}
