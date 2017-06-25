using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;

namespace FilterLists.Data.Models
{
    public class TableCsv : BaseEntity
    {
        [Required]
        [MaxLength(126)]
        [UsedImplicitly]
        public string Name { get; set; }

        [Required]
        [MaxLength(2083)]
        [MinLength(6)]
        [UsedImplicitly]
        public string Url { get; set; }
    }
}