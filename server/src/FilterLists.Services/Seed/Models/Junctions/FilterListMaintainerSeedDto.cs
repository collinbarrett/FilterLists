using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models.Junctions
{
    [UsedImplicitly]
    public class FilterListMaintainerSeedDto
    {
        public int FilterListId { get; set; }
        public int MaintainerId { get; set; }
    }
}