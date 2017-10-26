using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FilterLists.Data.Models.Contracts;
using Newtonsoft.Json;

namespace FilterLists.Data.Models.Implementations
{
    public class FilterList : BaseEntity, IFilterList
    {
        public List<Language> Languages { get; set; }

        [JsonIgnore]
        public virtual Maintainer Maintainer { get; set; }

        [Description(@"A brief description of the list's functionality. Preferably, this is quoted (if non-English, translate to English via translator or Google Translate for consistency) from the list's documentation or composed by a maintainer of the list. If neither are available, a generic description should be composed by the FilterLists contributor.")]
        [MaxLength(1022)]
        public string Description { get; set; }

        [Description(@"The URL to the list's documentation page from which the description was quoted if applicable.")]
        [Url]
        [MaxLength(2083)]
        [MinLength(6)]
        public string DescriptionSourceUrl { get; set; }

        [Description(@"The URL to the list's donation page. This could be a custom PayPal or similar link, or a link to a web page discussing various donation options. Pull requests that include changes to this link will undergo further verification to prevent fraud.")]
        [Url]
        [MaxLength(2083)]
        [MinLength(6)]
        public string DonateUrl { get; set; }

        [Description(@"The email address of the list's maintainer(s) if publicly available.")]
        [EmailAddress]
        [MaxLength(126)]
        [MinLength(7)]
        public string Email { get; set; }

        [Description(@"The URL to the list's forum where issues, change requests, etc. are discussed.")]
        [Url]
        [MaxLength(2083)]
        [MinLength(6)]
        public string ForumUrl { get; set; }

        [Description(@"The URL to the list's home page. Preferably, this is stated in the header of the list. Alternatively, it could be a custom domain, GitHub page, blog post, forum post, etc. that serves as a primary source of information for the list.")]
        [Url]
        [MaxLength(2083)]
        [MinLength(6)]
        public string HomeUrl { get; set; }

        [Description(@"The URL to the list's GitHub Issues.")]
        [Url]
        [MaxLength(2083)]
        [MinLength(6)]
        public string IssuesUrl { get; set; }

        [Description(@"The name of the list as stated by the list maintainer(s) in title case.")]
        [Required]
        [MaxLength(126)]
        public string Name { get; set; }

        [Description(@"The URL to the list in raw text format. zip files and other formats are acceptable if no text format is available.")]
        [Required]
        [Url]
        [MaxLength(2083)]
        [MinLength(6)]
        public string ViewUrl { get; set; }
    }
}