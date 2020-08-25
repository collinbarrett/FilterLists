using System;
using System.Diagnostics.CodeAnalysis;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class SegmentViewUrlMirror
    {
        public SegmentViewUrl SegmentViewUrl { get; private set; } = null!;
        public Uri Url { get; private set; } = null!;
    }
}