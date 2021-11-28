using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public abstract record EntityRequiringApproval : Entity
{
    // TODO: change 'set' to 'init' when no longer seeding from json
    public bool IsApproved { get; set; }
}

internal abstract class EntityRequiringApprovalTypeConfiguration<TEntityRequiringApproval>
    : IEntityTypeConfiguration<TEntityRequiringApproval> where TEntityRequiringApproval : EntityRequiringApproval
{
    public virtual void Configure(EntityTypeBuilder<TEntityRequiringApproval> builder)
    {
        builder.HasQueryFilter(e => e.IsApproved);
    }
}
