using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models.Junctions
{
    [UsedImplicitly]
    public class MergeSeedDto
    {
        public int MergeFilterListId { get; set; }
        public int UpstreamFilterListId { get; set; }
    }
}