using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models
{
    [UsedImplicitly]
    public class MaintainerSeedDto
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }
        public string TwitterHandle { get; set; }
    }
}