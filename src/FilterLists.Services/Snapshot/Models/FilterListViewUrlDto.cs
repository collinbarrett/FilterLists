using JetBrains.Annotations;

namespace FilterLists.Services.Snapshot.Models
{
    [UsedImplicitly]
    public class FilterListViewUrlDto
    {
        public uint Id { get; set; }
        public string ViewUrl { get; set; }
    }
}