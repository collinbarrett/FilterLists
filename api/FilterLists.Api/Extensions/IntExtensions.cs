using System;

namespace FilterLists.Api.Extensions;

public static class Extensions
{
    /// <summary>
    ///     Creates +1-based padded suffixes for 1-of-n denormalized property names.
    /// </summary>
    public static string ToIndexSuffix(this int i)
    {
        return $"_{(i + 1).ToString().PadLeft(2, '0')}";
    }

    public static string ToTableStorageKeyString(this long i)
    {
        return i.ToString().PadLeft(8, '0');
    }

    public static long FromTableStorageKeyString(this string s)
    {
        return long.Parse(s.TrimStart('0'));
    }

    public static string ToUrlString(this Uri uri)
    {
        return uri.IsAbsoluteUri ? uri.AbsoluteUri : uri.ToString();
    }
}