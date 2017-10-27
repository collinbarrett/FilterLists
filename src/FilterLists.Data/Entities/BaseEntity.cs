using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace FilterLists.Data.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public long Id { get; set; }

        [JsonIgnore]
        public DateTime CreatedDateUtc { get; set; }

        [JsonIgnore]
        public DateTime? ModifiedDateUtc { get; set; }
    }
}