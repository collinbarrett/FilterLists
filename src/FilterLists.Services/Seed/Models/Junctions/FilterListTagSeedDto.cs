using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models.Junctions
{
    [UsedImplicitly]
    public class FilterListTagSeedDto
    {
        public uint FilterListId { get; set; }
        public uint TagId { get; set; }
    }
}