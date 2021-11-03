using System.Text.Json;

namespace FilterLists.Directory.Domain.Aggregates.Changes;

public class Change
{
    private Change()
    {
    }

    public Change(ChangeType type, AggregateRoot aggregateRoot, int aggregateRootId, JsonDocument? aggregate)
    {
        Type = type;
        AggregateRoot = aggregateRoot;
        AggregateRootId = aggregateRootId;
        Aggregate = aggregate;
    }

    public ChangeType Type { get; private init; }
    public AggregateRoot AggregateRoot { get; private init; }
    public int AggregateRootId { get; private init; }
    public JsonDocument? Aggregate { get; private init; }
    public DateTime CreatedAt { get; private init; }
    public DateTime? AppliedAt { get; private init; }
    public DateTime? RejectedAt { get; private init; }
    public string? RejectedReason { get; private init; }
}
