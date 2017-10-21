using System.ComponentModel.DataAnnotations;
using FilterLists.Data.Models.Contracts;

namespace FilterLists.Data.Models.Implementations
{
    public class TableCsv : BaseEntity, ITableCsv
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