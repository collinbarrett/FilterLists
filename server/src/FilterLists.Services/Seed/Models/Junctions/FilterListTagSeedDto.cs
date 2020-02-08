using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models.Junctions
{
    [UsedImplicitly]
    public class FilterListTagSeedDto
    {
        public int FilterListId { get; set; }
        public int TagId { get; set; }
    }
}