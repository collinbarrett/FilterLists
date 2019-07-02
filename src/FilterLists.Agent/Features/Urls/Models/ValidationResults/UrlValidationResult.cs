using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterLists.Agent.Features.Urls.Models.ValidationResults
{
    public class UrlValidationResult
    {
        public UrlValidationResult(Uri url)
        {
            Url = url;
        }

        public Uri Url { get; }

        public List<string> Messages { get; } = new List<string>();

        public bool IsValid()
        {
            return !Messages.Any();
        }

        public void SetBroken()
        {
            Messages.Add("The URL is broken and should maybe be fixed, replaced, or removed.");
        }

        public void SetSupportsHttps()
        {
            Messages.Add("The URL is set to `http` but can support and should probably be changed to `https`.");
        }

        public void SetRedirectsTo(Uri uri)
        {
            Messages.Add($"The URL redirects and should maybe be changed to `{uri}`.");
        }
    }
}