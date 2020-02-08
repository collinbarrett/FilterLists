using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.Syntax.Models
{
    [UsedImplicitly]
    public class SyntaxDto
    {
        public int Id { get; set; }
        public string DefinitionUrl { get; set; }
        public List<int> FilterListIds { get; set; }
        public string Name { get; set; }
        public List<int> SoftwareIds { get; set; }
    }
}