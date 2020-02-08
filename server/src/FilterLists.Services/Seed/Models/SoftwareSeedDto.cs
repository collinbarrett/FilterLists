using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models
{
    [UsedImplicitly]
    public class SoftwareSeedDto
    {
        public int Id { get; set; }
        public string DownloadUrl { get; set; }
        public string HomeUrl { get; set; }
        public bool IsAbpSubscribable { get; set; }
        public string Name { get; set; }
    }
}