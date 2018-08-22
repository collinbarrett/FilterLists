using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.Models
{
    [UsedImplicitly]
    public class ListTagDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ColorHex { get; set; }
    }
}