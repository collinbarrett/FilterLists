using CommandLine;
using JetBrains.Annotations;

namespace FilterLists.Agent
{
    [UsedImplicitly]
    public class Options
    {
        public Options(bool captureLists, bool validateUrls)
        {
            CaptureLists = captureLists;
            ValidateUrls = validateUrls;
        }

        [Option('c', "capture", Required = false, HelpText = "Capture copies of all lists in the archives repository.")]
        public bool CaptureLists { get; }

        [Option('v', "validate", Required = false, HelpText = "Validate all URLs in the FilterLists database.")]
        public bool ValidateUrls { get; }
    }
}