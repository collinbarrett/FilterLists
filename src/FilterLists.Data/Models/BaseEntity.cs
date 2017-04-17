using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;

namespace FilterLists.Data.Models
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [UsedImplicitly]
        public long Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //TODO: Implement http://stackoverflow.com/a/38102266/2343739 so DefaultValue takes effect in db automatically
        //For now, manually execute on new tables: InitializeNewTableBaseEntityDefaults.sql
        [DefaultValue("CURRENT_TIMESTAMP")]
        [UsedImplicitly]
        public DateTime AddedDateUtc { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [UsedImplicitly]
        public DateTime? ModifiedDateUtc { get; set; }
    }
}