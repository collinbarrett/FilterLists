using JetBrains.Annotations;

namespace FilterLists.Agent.Core.Entities
{
    [UsedImplicitly]
    public class MaintainerUrls : IEntityUrls
    {
        public int Id { get; set; }
        public string HomeUrl { get; set; }
    }
}