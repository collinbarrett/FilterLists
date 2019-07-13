using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterLists.Agent.Core.Urls
{
    public class EntityUrl
    {
        public EntityUrl(Entity entity, int id, Uri url)
        {
            Entity = entity;
            Id = id;
            Url = url;
        }

        public Entity Entity { get; }

        public int Id { get; }

        public Uri Url { get; }

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