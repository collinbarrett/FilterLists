using System.ComponentModel.DataAnnotations;

namespace FilterLists.Models
{
    public class List : BaseEntity
    {
        [MaxLength(1022)]
        public string Description { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        public string DescriptionSourceUrl { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        public string DonateUrl { get; set; }

        [MaxLength(254)]
        [MinLength(7)]
        public string Email { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        public string ForumUrl { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        public string HomeUrl { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        public string IssuesUrl { get; set; }

        [MaxLength(510)]
        public string Name { get; set; }

        [Required]
        [MaxLength(2083)]
        [MinLength(6)]
        public string ViewUrl { get; set; }
    }
}