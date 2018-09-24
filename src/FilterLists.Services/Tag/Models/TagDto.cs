using JetBrains.Annotations;

namespace FilterLists.Services.Tag.Models
{
    [UsedImplicitly]
    public class TagDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}