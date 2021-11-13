using System.Text.Json;
using FilterLists.Directory.Domain.Aggregates.Licenses;

namespace FilterLists.Directory.Domain.Aggregates.Changes;

public class Change
{
    private Change()
    {
    }

    public Change(ChangeType type)
    {
        Type = type;
    }

    public ChangeType Type { get; init; }
    public JsonDocument? AggregateBefore { get; init; }
    public JsonDocument? AggregateAfter { get; init; }

    public DateTime CreatedAt { get; init; }
    public string? CreatedReason { get; init; }
    public DateTime? AppliedAt { get; init; }
    public DateTime? RejectedAt { get; init; }
    public string? RejectedReason { get; init; }

    public FilterList? FilterList { get; init; }
    //public Language? Language { get; }
    public License? License { get; init; }
    //public Maintainer? Maintainer { get; }
    //public Software? Software { get; }
    //public Syntax? Syntax { get; }
    //public Tag? Tag { get; }
}
