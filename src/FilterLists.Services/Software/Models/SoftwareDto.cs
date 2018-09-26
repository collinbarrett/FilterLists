using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.Software.Models
{
    [UsedImplicitly]
    public class SoftwareDto
    {
        public int Id { get; set; }
        public string HomeUrl { get; set; }
        public bool IsAbpSubscribable { get; set; }
        public string Name { get; set; }
        public List<int> SyntaxIds { get; set; }
    }
}