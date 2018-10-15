using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace FilterLists.Services
{
    public static class UserAgentService
    {
        private const string UaStringSource = "https://techblog.willshouse.com/2012/01/03/most-common-user-agents/";
        private const string UaStringSourceClass = "get-the-list";

        private const string UaStringDefault =
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36";

        public static async Task<string> GetMostPopularStringAsync()
        {
            try
            {
                return await TryGetLatestMostPopularStringOrDefault();
            }
            catch (HttpRequestException)
            {
                return UaStringDefault;
            }
        }

        private static async Task<string> TryGetLatestMostPopularStringOrDefault()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(UaStringSource, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var streamReader = new StreamReader(stream))
                {
                    string line;
                    while ((line = await streamReader.ReadLineAsync()) != null)
                        if (line.Contains(UaStringSourceClass))
                            return ParseUaStringOrDefault(line);
                }
            }

            return UaStringDefault;
        }

        private static string ParseUaStringOrDefault(string line)
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