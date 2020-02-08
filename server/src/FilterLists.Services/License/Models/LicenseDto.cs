using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.License.Models
{
    [UsedImplicitly]
    public class LicenseDto
    {
        public int Id { get; set; }
        public string DescriptionUrl { get; set; }
        public List<int> FilterListIds { get; set; }
        public string Name { get; set; }
    }
}