using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models.Junctions
{
    [UsedImplicitly]
    public class DependentSeedDto
    {
        public uint DependentFilterListId { get; set; }
        public uint DependencyFilterListId { get; set; }
    }
}