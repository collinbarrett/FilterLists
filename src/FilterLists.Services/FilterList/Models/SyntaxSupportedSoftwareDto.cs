using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.Models
{
    [UsedImplicitly]
    public class SyntaxSupportedSoftwareDto
    {
        public int Id { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }
    }
}