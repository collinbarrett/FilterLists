using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.Models
{
    [UsedImplicitly]
    public class ListLanguagesDto
    {
        public string Name { get; set; }
        public string Iso6391 { get; set; }
    }
}