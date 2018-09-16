using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.Models
{
    [UsedImplicitly]
    public class SyntaxSupportedSoftwareDto
    {
        public uint Id { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }
    }
}