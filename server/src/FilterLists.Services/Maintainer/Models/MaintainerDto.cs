using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.Maintainer.Models
{
    [UsedImplicitly]
    public class MaintainerDto
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public List<int> FilterListIds { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }
        public string TwitterHandle { get; set; }
    }
}