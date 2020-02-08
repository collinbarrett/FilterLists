using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.Tag.Models
{
    [UsedImplicitly]
    public class TagDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<int> FilterListIds { get; set; }
        public string Name { get; set; }
    }
}