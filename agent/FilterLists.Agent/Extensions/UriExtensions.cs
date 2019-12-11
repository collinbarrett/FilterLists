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
    }
}