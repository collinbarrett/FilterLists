using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.List.Models
{
    [UsedImplicitly]
    public class ListSyntaxDto
    {
        public string DefinitionUrl { get; set; }
        public string Name { get; set; }
        public IEnumerable<SyntaxSupportedSoftwareDto> SupportedSoftware { get; set; }
    }
}