namespace FilterLists.Api.Extensions;

public static class IntExtensions
{
    /// <summary>
    ///     Creates +1-based padded suffixes for 1-of-n denormalized property names.
    /// </summary>
    public static string ToIndexSuffix(this int i)
    {
        return $"_{(i + 1).ToString().PadLeft(2, '0')}";
    }
}