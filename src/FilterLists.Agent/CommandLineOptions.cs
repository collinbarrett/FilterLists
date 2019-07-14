using CommandLine;

namespace FilterLists.Agent
{
    public class CommandLineOptions
    {
        public CommandLineOptions(bool archiveLists, bool validateUrls)
        {
            ArchiveLists = archiveLists;
            ValidateUrls = validateUrls;
        }

        [Option('a', "archive", Required = false, HelpText = "Archive copies of all lists in a git repository.")]
        public bool ArchiveLists { get; }

        [Option('v', "validate", Required = false, HelpText = "Validate all URLs in the FilterLists database.")]
        public bool ValidateUrls { get; }

        public bool Any()
        {
            return ArchiveLists || ValidateUrls;
        }
    }
}