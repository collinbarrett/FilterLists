using System.Collections.Generic;

namespace FilterLists.Agent.Features.Urls
{
    public class DataFileUrlValidationResults
    {
        public DataFileUrlValidationResults(string dataFileName, IEnumerable<UrlValidationResult> results)
        {
            DataFileName = dataFileName;
            Results = results;
        }

        public string DataFileName { get; }

        public IEnumerable<UrlValidationResult> Results { get; }
    }
}