using JetBrains.Annotations;

namespace FilterLists.Services.List.Models
{
    [UsedImplicitly]
    public class ListTagDto
    {
        public string Name { get; set; }
        public string ColorHex { get; set; }
        public string Description { get; set; }
    }
}