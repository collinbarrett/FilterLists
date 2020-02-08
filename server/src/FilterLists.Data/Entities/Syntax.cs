using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;
using JetBrains.Annotations;

namespace FilterLists.Data.Entities
{
    [UsedImplicitly]
    public class Syntax : BaseEntity
    {
        public string DefinitionUrl { get; set; }
        public ICollection<FilterList> FilterLists { get; set; }
        public string Name { get; set; }
        public ICollection<SoftwareSyntax> SoftwareSyntaxes { get; set; }
    }
}