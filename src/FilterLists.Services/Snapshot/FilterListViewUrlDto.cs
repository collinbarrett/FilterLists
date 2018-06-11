using JetBrains.Annotations;

namespace FilterLists.Services.Snapshot
{
    [UsedImplicitly]
    public class FilterListViewUrlDto
    {
        public uint Id { get; set; }
        public string ViewUrl { get; set; }
    }
}