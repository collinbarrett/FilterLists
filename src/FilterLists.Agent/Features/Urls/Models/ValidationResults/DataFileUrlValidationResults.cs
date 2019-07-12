using System.Collections.Generic;
using FilterLists.Agent.Core.Urls;

namespace FilterLists.Agent.Features.Urls.Models.ValidationResults
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