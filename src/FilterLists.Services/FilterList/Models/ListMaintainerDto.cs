using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.Models
{
    [UsedImplicitly]
    public class ListMaintainerDto
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }
        public string TwitterHandle { get; set; }
        public IEnumerable<MaintainerAdditionalListsDto> AdditionalLists { get; set; }
    }
}