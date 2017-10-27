using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FilterLists.Data.Entities
{
    public class Maintainer : BaseEntity
    {
        public List<FilterList> FilterLists { get; set; }

        [Description(@"The email address of the list maintainer.")]
        [EmailAddress]
        [MaxLength(126)]
        [MinLength(7)]
        public string Email { get; set; }

        [Description(@"The URL to the list maintainer's home page.")]
        [Url]
        [MaxLength(2083)]
        [MinLength(6)]
        public string HomeUrl { get; set; }

        [Description(@"The name of the list maintainer.")]
        [Required]
        [MaxLength(126)]
        public string Name { get; set; }

        [Description(@"The Twitter handle of the list maintainer.")]
        [MaxLength(126)]
        public string TwitterHandle { get; set; }
    }
}