using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FilterLists.Services.Snapshot.Models.Wayback
{
    [UsedImplicitly]
    public class Availability
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("archived_snapshots")]
        public ArchivedSnapshots ArchivedSnapshots { get; set; }
    }
}