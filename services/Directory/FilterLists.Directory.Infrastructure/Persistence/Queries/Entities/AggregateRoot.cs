using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public abstract record AggregateRoot
{
    public bool? IsApproved { get; private init; }
}

internal abstract class AggregateRootTypeConfiguration<TAggregateRoot> : IEntityTypeConfiguration<TAggregateRoot>
    where TAggregateRoot : AggregateRoot
{
    public virtual void Configure(EntityTypeBuilder<TAggregateRoot> builder)
    {
        builder.Property(e => e.IsApproved)
            .IsRequired()
            .HasDefaultValue(true); // legacy json data approved via GitHub PR
    }
}
