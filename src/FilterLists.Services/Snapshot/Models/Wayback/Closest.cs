using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FilterLists.Services.Snapshot.Models.Wayback
{
    [UsedImplicitly]
    public class Closest
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}