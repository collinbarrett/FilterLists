using System;

namespace FilterLists.Data.Entities.Junctions
{
    public class SoftwareSyntax
    {
        public DateTime CreatedDateUtc { get; set; }

        public int SoftwareId { get; set; }
        public Software Software { get; set; }

        public int SyntaxId { get; set; }
        public Syntax Syntax { get; set; }
    }
}