using System.Text.Json;
using FilterLists.Directory.Domain.Aggregates.Changes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public class Change
{
    public int Id { get; init; }
    public ChangeType Type { get; init; }
    public AggregateRoot AggregateRoot { get; init; }
    public int AggregateRootId { get; init; }
    public JsonDocument? Aggregate { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? AppliedAt { get; init; }
    public DateTime? RejectedAt { get; init; }
    public string? RejectedReason { get; init; }
}

internal class UpdateConfiguration : IEntityTypeConfiguration<Change>
{
    public virtual void Configure(EntityTypeBuilder<Change> builder)
    {
        builder.Property(c => c.CreatedAt)
            .HasDefaultValueSql("now()");
    }
}
