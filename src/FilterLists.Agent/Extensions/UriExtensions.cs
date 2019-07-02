using System;
using System.IO;

namespace FilterLists.Agent.Extensions
{
    public static class UriExtensions
    {
        public static string GetExtension(this Uri uri)
        {
            return Path.GetExtension(uri.AbsolutePath);
        }

        public static bool IsValidUrl(this Uri uri)
        {
            var uriString = uri.OriginalString;
            if (!Uri.IsWellFormedUriString(uriString, UriKind.Absolute))
                return false;
            if (!Uri.TryCreate(uriString, UriKind.Absolute, out var tmp))
                return false;
            return tmp.Scheme == Uri.UriSchemeHttp || tmp.Scheme == Uri.UriSchemeHttps;
        }
    }
}