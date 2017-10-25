using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FilterLists.Data.Models.Contracts;
using Newtonsoft.Json;

namespace FilterLists.Data.Models.Implementations
{
    public abstract class BaseEntity : IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public long Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        //TODO: Implement http://stackoverflow.com/a/38102266/2343739 so DefaultValue takes effect in db automatically
        //For now, manually execute on new tables: InitializeNewTableBaseEntityDefaults.sql
        [DefaultValue("CURRENT_TIMESTAMP")]
        public DateTime AddedDateUtc { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [JsonIgnore]
        public DateTime? ModifiedDateUtc { get; set; }
    }
}