using System.ComponentModel.DataAnnotations;

namespace FilterLists.Data.Models
{
    public class TableCsv : BaseEntity
    {
        [Required]
        [MaxLength(126)]
        public string Name { get; set; }

        [Required]
        [MaxLength(2083)]
        [MinLength(6)]
        public string Url { get; set; }
    }
}