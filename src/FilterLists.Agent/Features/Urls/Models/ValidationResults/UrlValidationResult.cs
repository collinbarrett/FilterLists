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
            Messages.Add("This URL might be broken and should maybe be fixed, replaced, or removed.");
        }

        public void SetSupportsHttps()
        {
            Messages.Add(
                "This URL uses the HTTP protocol but appears to be able to support and should probably be changed to HTTPS.");
        }

        public void SetRedirectsTo(Uri uri)
        {
            Messages.Add($"This URL appears to redirect and should maybe be changed to \"{uri}\".");
        }
    }
}