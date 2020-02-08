using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models.Junctions
{
    [UsedImplicitly]
    public class DependentSeedDto
    {
        public int DependentFilterListId { get; set; }
        public int DependencyFilterListId { get; set; }
    }
}