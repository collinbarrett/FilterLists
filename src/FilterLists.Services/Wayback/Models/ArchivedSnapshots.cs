using JetBrains.Annotations;
using Newtonsoft.Json;

namespace FilterLists.Services.Wayback.Models
{
    [UsedImplicitly]
    public class ArchivedSnapshots
    {
        [JsonProperty("closest")]
        public Closest Closest { get; set; }
    }
}