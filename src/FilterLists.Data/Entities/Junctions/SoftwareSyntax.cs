namespace FilterLists.Data.Entities.Junctions
{
    public class SoftwareSyntax : BaseJunctionEntity
    {
        public uint SoftwareId { get; set; }
        public Software Software { get; set; }
        public uint SyntaxId { get; set; }
        public Syntax Syntax { get; set; }
    }
}