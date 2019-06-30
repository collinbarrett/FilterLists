using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using SharpCompress.Archives;
using SharpCompress.Common;
using SharpCompress.Readers;

namespace FilterLists.Agent.ListArchiver
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
        public static async Task CopyToWithCompressedArchiveApi(this Stream input, Stream output,
            CancellationToken cancellationToken)
        {
            //var archive = ArchiveFactory.Open(@"C:\Code\sharpcompress\TestArchives\sharpcompress.zip");
            //foreach (var entry in archive.Entries)
            //    if (!entry.IsDirectory)
            //    {
            //        Console.WriteLine(entry.Key);
            //        entry.WriteToDirectory(@"C:\temp",
            //            new ExtractionOptions {ExtractFullPath = true, Overwrite = true});
            //    }

            throw new NotImplementedException();
        }
    }
}