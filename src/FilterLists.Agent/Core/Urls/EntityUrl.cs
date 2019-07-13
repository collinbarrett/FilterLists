using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterLists.Agent.Core.Urls
{
    public class EntityUrl
    {
        public EntityUrl(FilterListsEntity filterListsEntity, int id, Uri viewUrl)
        {
            FilterListsEntity = filterListsEntity;
            Id = id;
            ViewUrl = viewUrl;
        }

        public FilterListsEntity FilterListsEntity { get; }
        public int Id { get; }
        public Uri ViewUrl { get; }
        public List<string> ValidationMessages { get; } = new List<string>();

        public bool IsValid()
        {
            return !ValidationMessages.Any();
        }

        public void SetBroken()
        {
            ValidationMessages.Add("This URL might be broken and should maybe be fixed, replaced, or removed.");
        }

        public void SetSupportsHttps()
        {
            ValidationMessages.Add(
                "This URL uses the HTTP protocol but appears to be able to support and should probably be changed to HTTPS.");
        }

        public void SetRedirectsTo(Uri uri)
        {
            ValidationMessages.Add($"This URL appears to redirect and should maybe be changed to \"{uri}\".");
        }
    }
}