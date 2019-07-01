using JetBrains.Annotations;

namespace FilterLists.Agent.Core.Entities
{
    [UsedImplicitly]
    public class SoftwareUrls : IEntityUrls
    {
        public int Id { get; set; }
        public string DownloadUrl { get; set; }
        public string HomeUrl { get; set; }
    }
}