using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models.Junctions
{
    [UsedImplicitly]
    public class ForkSeedDto
    {
        public uint ForkFilterListId { get; set; }
        public uint UpstreamFilterListId { get; set; }
    }
}