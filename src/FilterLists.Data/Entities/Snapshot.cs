namespace FilterLists.Data.Entities
{
    public class Snapshot : BaseEntity
    {
        public string Content { get; set; }
        public int FilterListId { get; set; }
    }
}