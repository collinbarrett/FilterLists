using System;
using FilterLists.Agent.Core.Entities;
using JetBrains.Annotations;

namespace FilterLists.Agent.Features.Urls.Models
{
    [UsedImplicitly]
    public class MaintainerUrls : IEntityUrls
    {
        public Uri HomeUrl { get; set; }
    }
}