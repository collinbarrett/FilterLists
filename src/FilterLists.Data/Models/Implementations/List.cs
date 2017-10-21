using System.ComponentModel.DataAnnotations;
using FilterLists.Data.Models.Contracts;

namespace FilterLists.Data.Models.Implementations
{
    public class List : BaseEntity, IList
    {
        [MaxLength(126)]
        public string Name { get; set; }

        [Required]
        [MaxLength(2083)]
        [MinLength(6)]
        public string ViewUrl { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        public string HomeUrl { get; set; }

        [MaxLength(1022)]
        public string Description { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        public string DescriptionSourceUrl { get; set; }

        [MaxLength(126)]
        public string Author { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        public string ForumUrl { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        public string IssuesUrl { get; set; }

        [MaxLength(126)]
        [MinLength(7)]
        public string Email { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        public string DonateUrl { get; set; }
    }
}