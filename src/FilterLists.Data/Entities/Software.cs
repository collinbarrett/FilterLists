using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;
using JetBrains.Annotations;

namespace FilterLists.Data.Entities
{
    [UsedImplicitly]
    public class Software : BaseEntity
    {
        public string DownloadUrl { get; set; }
        public string HomeUrl { get; set; }
        public bool IsAbpSubscribable { get; set; }
        public string Name { get; set; }
        public ICollection<SoftwareSyntax> SoftwareSyntaxes { get; set; }
    }
}