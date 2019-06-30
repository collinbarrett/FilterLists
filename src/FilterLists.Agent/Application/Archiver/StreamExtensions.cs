using System.IO;
using System.Threading;
using System.Threading.Tasks;
using SharpCompress.Archives;
using SharpCompress.Archives.SevenZip;
using SharpCompress.Readers;

namespace FilterLists.Agent.Application.Archiver
{
    public static class StreamExtensions
    {
        /// <summary>
        ///     Downloads compressed streams that support forward-only reading.
        ///     e.g. Zip, GZip, BZip2, Tar, Rar, LZip, XZ
        ///     https://github.com/adamhathcock/sharpcompress/blob/master/FORMATS.md
        /// </summary>
        public static async Task CopyToWithCompressedReaderApi(this Stream input, Stream output,
            CancellationToken cancellationToken)
        {
            using (var reader = ReaderFactory.Open(input))
            {
                while (reader.MoveToNextEntry())
                    if (!reader.Entry.IsDirectory)
                        using (var entryStream = reader.OpenEntryStream())
                        {
                            await entryStream.CopyToAsync(output, cancellationToken);
                        }
            }
        }

        /// <summary>
        ///     Downloads compressed streams that only support the Archive API.
        ///     e.g. 7zip
        ///     https://github.com/adamhathcock/sharpcompress/blob/master/FORMATS.md
        /// </summary>
        public static void CopyToWithCompressedArchiveApi(this Stream input, Stream output)
        {
            using (var archive = SevenZipArchive.Open(input))
            {
                foreach (var entry in archive.Entries)
                    if (!entry.IsDirectory)
                        entry.WriteTo(output);
            }
        }
    }
}