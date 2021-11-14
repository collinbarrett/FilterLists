using FilterLists.Directory.Domain.Aggregates.FilterLists;

namespace FilterLists.Directory.Domain.Aggregates.Changes;

public sealed class FilterListChange : Change, IChangeAggregate<FilterList>
{
    private FilterListChange()
    {
    }

    private FilterListChange(FilterList current, string? reason)
    {
        Current = current;
        Reason = reason;
    }

    public FilterList? Current { get; init; }
    public FilterList? Before { get; init; }
    public FilterList? After { get; init; }

    public static FilterListChange Create(FilterList filterList, string? reason)
    {
        return new FilterListChange(filterList, reason) { After = filterList };
    }

    public static FilterListChange Update(FilterList before, FilterList after, string? reason)
    {
        return new FilterListChange(before, reason) { Before = before, After = after };
    }

    public static FilterListChange Delete(FilterList filterList, string? reason)
    {
        return new FilterListChange(filterList, reason) { Before = filterList };
    }
}
