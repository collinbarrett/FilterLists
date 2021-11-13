using System.Text.Json;
using FilterLists.Directory.Domain.Aggregates.FilterLists;

namespace FilterLists.Directory.Domain.Aggregates.Changes;

public class Change
{
    private Change()
    {
    }

    public ChangeType Type { get; init; }

    // TODO: push json handling from Domain to Infrastructure
    public JsonDocument? AggregateBefore { get; init; }
    public JsonDocument? AggregateAfter { get; init; }

    public string? Reason { get; init; }
    public DateTime SubmittedAt { get; init; } = DateTime.UtcNow;
    public DateTime? AppliedAt { get; init; }
    public DateTime? RejectedAt { get; init; }
    public string? RejectedReason { get; init; }
    //public int? FilterListId { get; init; }
    public FilterList? FilterList { get; init; }
    //public string? LanguageIso6391 { get; init; }
    //public Language? Language { get; }
    //public int? LicenseId { get; init; }
    //public License? License { get; }
    //public int? MaintainerId { get; init; }
    //public Maintainer? Maintainer { get; }
    //public int? SoftwareId { get; init; }
    //public Software? Software { get; }
    //public int? SyntaxId { get; init; }
    //public Syntax? Syntax { get; }
    //public int? TagId { get; init; }
    //public Tag? Tag { get; }

    public static Change CreateFilterList(FilterList filterList, string? reason)
    {
        return new Change
        {
            Type = ChangeType.Create,
            AggregateAfter = JsonSerializer.SerializeToDocument(filterList),
            Reason = reason,
            FilterList = filterList
        };
    }
}
