using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace FilterLists.Services
{
    [UsedImplicitly]
    public static class UserAgentService
    {
        private const string UaStringSource = "https://techblog.willshouse.com/2012/01/03/most-common-user-agents/";
        private const string UaStringSourceClass = "get-the-list";

        private const string UaStringDefault =
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36";

        public static async Task<string> GetMostPopularString()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(UaStringSource, HttpCompletionOption.ResponseHeadersRead);
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var streamReader = new StreamReader(stream))
                {
                    string line;
                    while ((line = await streamReader.ReadLineAsync()) != null)
                        if (line.Contains(UaStringSourceClass))
                            return ParseUaString(line);
                }
            }

            return UaStringDefault;
        }

        private static string ParseUaString(string line)
        {
            var classIndex = line.IndexOf(UaStringSourceClass, StringComparison.Ordinal);
            var postClassIndexSubstring = line.Substring(classIndex);
            var uaStringStartIndex = postClassIndexSubstring.IndexOf(">", StringComparison.Ordinal) + 1;
            var uaString = postClassIndexSubstring.Substring(uaStringStartIndex).Trim();
            return IsSane(uaString) ? uaString : UaStringDefault;
        }

        private static bool IsSane(string uaString) =>
            uaString.Length > 25 && uaString.Length < 300 && uaString.Contains("Mozilla");
    }
}