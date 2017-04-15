using System.ComponentModel.DataAnnotations;

//using JetBrains.Annotations;

namespace FilterLists.Data.Models
{
    public class List : BaseEntity
    {
        [MaxLength(1022)]
        //[UsedImplicitly]
        public string Description { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        //[UsedImplicitly]
        public string DescriptionSourceUrl { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        //[UsedImplicitly]
        public string DonateUrl { get; set; }

        [MaxLength(126)]
        [MinLength(7)]
        //[UsedImplicitly]
        public string Email { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        //[UsedImplicitly]
        public string ForumUrl { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        //[UsedImplicitly]
        public string HomeUrl { get; set; }

        [MaxLength(2083)]
        [MinLength(6)]
        //[UsedImplicitly]
        public string IssuesUrl { get; set; }

        [MaxLength(126)]
        //[UsedImplicitly]
        public string Name { get; set; }

        [Required]
        [MaxLength(2083)]
        [MinLength(6)]
        //[UsedImplicitly]
        public string ViewUrl { get; set; }
    }
}