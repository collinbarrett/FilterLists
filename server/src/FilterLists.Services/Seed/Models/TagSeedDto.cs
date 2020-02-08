using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models
{
    [UsedImplicitly]
    public class TagSeedDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}