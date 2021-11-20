using FilterLists.Directory.Domain.Aggregates.FilterLists;

namespace FilterLists.Directory.Domain.Aggregates.Changes;

public sealed class FilterListChange : Change, IChange<FilterListCore>
{
    private FilterListChange() { }

    public FilterListCore? Before { get; private init; }
    public FilterListCore? After { get; private init; }

    public static FilterListChange Create(FilterList filterList, string? reason)
    {
        return new FilterListChange { After = filterList, Reason = reason };
    }

    public static FilterListChange Update(FilterList before, FilterList after, string? reason)
    {
        return new FilterListChange { Before = before, After = after, Reason = reason };
    }

    public static FilterListChange Delete(FilterList filterList, string? reason)
    {
        return new FilterListChange { Before = filterList, Reason = reason };
    }
}
