namespace FilterLists.Data.Entities.Junctions
{
    public class SoftwareSyntax : BaseJunctionEntity
    {
        public int SoftwareId { get; set; }
        public Software Software { get; set; }
        public int SyntaxId { get; set; }
        public Syntax Syntax { get; set; }
    }
}