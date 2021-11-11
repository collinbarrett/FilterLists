namespace FilterLists.Archival.Domain.ListArchives
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
