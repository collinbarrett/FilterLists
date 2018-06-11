using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models.Junctions
{
    [UsedImplicitly]
    public class MergeSeedDto
    {
        public uint MergeFilterListId { get; set; }
        public uint UpstreamFilterListId { get; set; }
    }
}