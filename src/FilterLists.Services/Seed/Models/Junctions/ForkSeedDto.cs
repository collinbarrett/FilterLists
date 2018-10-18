using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models.Junctions
{
    [UsedImplicitly]
    public class ForkSeedDto
    {
        public int ForkFilterListId { get; set; }
        public int UpstreamFilterListId { get; set; }
    }
}