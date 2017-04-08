using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilterLists.Models
{
    public class List : BaseEntity
    {
        [StringLength(1024)] [Column("description")] public string Description;
        [StringLength(512)] [Column("description_source_url")] public string DescriptionSourceUrl;
        [StringLength(512)] [Column("donate_url")] public string DonateUrl;
        [StringLength(128)] [Column("email")] public string Email;
        [StringLength(512)] [Column("forum_url")] public string ForumUrl;
        [StringLength(512)] [Column("home_url")] public string HomeUrl;
        [Key] [Column("id")] public new int Id;
        [StringLength(512)] [Column("issues_url")] public string IssuesUrl;
        [StringLength(256)] [Column("name")] public string Name;
        [StringLength(512)] [Column("view_url")] public string ViewUrl;
    }
}