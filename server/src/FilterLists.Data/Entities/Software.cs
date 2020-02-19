using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class Software : BaseEntity
    {
        public string DownloadUrl { get; set; }
        public string HomeUrl { get; set; }
        public bool IsAbpSubscribable { get; set; }
        public string Name { get; set; }
        public ICollection<SoftwareSyntax> SoftwareSyntaxes { get; set; }
    }
}