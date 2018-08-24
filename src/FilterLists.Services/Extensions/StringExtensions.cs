using System;
using System.Linq;

namespace FilterLists.Services.Extensions
{
    public static class StringExtensions
    {
        public static bool IsValidHttpOrHttpsUrl(this string source) =>
            Uri.TryCreate(source, UriKind.Absolute, out var uriResult) &&
            new[] {Uri.UriSchemeHttps, Uri.UriSchemeHttp}.Contains(uriResult.Scheme);

        public static int GetNthIndexOfChar(this string s, int n, char t) =>
            s.TakeWhile(c => (n -= c == t ? 1 : 0) > 0).Count();
    }
}