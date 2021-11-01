using System;
using System.IO;

namespace FilterLists.Archival.Domain.Extensions
{
    internal static class UriExtension
    {
        private static readonly Uri DummyBaseUri = new("http://localhost");

        public static string GetFileExtension(this Uri uri)
        {
            if (!uri.IsAbsoluteUri)
            {
                uri = new Uri(DummyBaseUri, uri);
            }

            return Path.GetExtension(uri.LocalPath);
        }
    }
}
