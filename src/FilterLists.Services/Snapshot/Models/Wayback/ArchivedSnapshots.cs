using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FilterLists.Services.Snapshot.Models.Wayback
{
    [UsedImplicitly]
    public class ArchivedSnapshots
    {
        [JsonProperty("closest")]
        public Closest Closest { get; set; }
    }
}