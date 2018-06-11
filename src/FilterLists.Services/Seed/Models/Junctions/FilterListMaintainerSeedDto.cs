using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models.Junctions
{
    [UsedImplicitly]
    public class FilterListMaintainerSeedDto
    {
        public uint FilterListId { get; set; }
        public uint MaintainerId { get; set; }
    }
}