using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FilterLists.Data.Models.Contracts;

namespace FilterLists.Data.Models.Implementations
{
    public class Maintainer : BaseEntity, IMaintainer
    {
        public List<FilterList> FilterLists { get; set; }

        [Description(@"The author (person or group) who maintains the list.")]
        [Required]
        [MaxLength(126)]
        public string Name { get; set; }

        [Description(@"The email address of the list's maintainer(s) if publicly available.")]
        [EmailAddress]
        [MaxLength(126)]
        [MinLength(7)]
        public string Email { get; set; }

        [Description(@"The email address of the list's maintainer(s) if publicly available.")]
        [MaxLength(126)]
        public string TwitterHandle { get; set; }

        [Description(
            @"The URL to the list's home page. Preferably, this is stated in the header of the list. Alternatively, it could be a custom domain, GitHub page, blog post, forum post, etc. that serves as a primary source of information for the list.")]
        [Url]
        [MaxLength(2083)]
        [MinLength(6)]
        public string HomeUrl { get; set; }
    }
}