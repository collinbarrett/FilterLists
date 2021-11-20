using FilterLists.Directory.Domain.Aggregates.FilterLists;

namespace FilterLists.Directory.Domain.Aggregates.Changes;

public sealed class FilterListChange : Change, IChangeAggregate<FilterListRecord>
{
    private FilterListChange() { }

    public FilterListRecord? Before { get; private init; }
    public FilterListRecord? After { get; private init; }

    public static FilterListChange Create(FilterList filterList, string? reason)
    {
        return new FilterListChange { After = FilterListRecord.FromFilterList(filterList), Reason = reason };
    }

    public static FilterListChange Update(FilterList before, FilterList after, string? reason)
    {
        return new FilterListChange
        {
            Before = FilterListRecord.FromFilterList(before),
            After = FilterListRecord.FromFilterList(after),
            Reason = reason
        };
    }

    public static FilterListChange Delete(FilterList filterList, string? reason)
    {
        return new FilterListChange { Before = FilterListRecord.FromFilterList(filterList), Reason = reason };
    }
}
