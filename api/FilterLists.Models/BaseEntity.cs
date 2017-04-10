//https://code.msdn.microsoft.com/Generic-Repository-Pattern-f133bca4/sourcecode?fileId=164016&pathId=1938870460

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilterLists.Models
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //TODO: Implement http://stackoverflow.com/a/38102266/2343739 so DefaultValue takes effect in db automatically
        [DefaultValue("CURRENT_TIMESTAMP")]
        public DateTime AddedDateUtc { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("CURRENT_TIMESTAMP")]
        public DateTime ModifiedDateUtc { get; set; }
    }
}