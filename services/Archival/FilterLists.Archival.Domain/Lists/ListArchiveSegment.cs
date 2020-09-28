﻿using System;
using System.IO;

namespace FilterLists.Archival.Domain.Lists
{
    public class ListArchiveSegment
    {
        public ListArchiveSegment(Uri sourceUri, Stream content)
        {
            Extension = ListFileExtension.FromUri(sourceUri);
            Content = content;
        }

        public ListFileExtension Extension { get; }
        public Stream Content { get; }
    }
}
