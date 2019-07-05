using JetBrains.Annotations;

namespace FilterLists.Agent.AppSettings
{
    public class ArchiveSettings
    {
        public string CommitMessageSuffix { get; [UsedImplicitly] set; }
        public string RepositoryDirectory { get; [UsedImplicitly] set; }
        public string SignatureName { get; [UsedImplicitly] set; }
        public string SignatureEmail { get; [UsedImplicitly] set; }
    }
}