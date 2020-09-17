using System;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    public class Txt : IFileWriteStrategy
    {
        public async Task WriteAsync(IFileToArchive file, CancellationToken cancellationToken = default)
        {
            _ = file ?? throw new ArgumentNullException(nameof(file));

            await using var target = file.Target.OpenWrite();
            foreach (var source in file.Contents)
            {
                await source.CopyToAsync(target, cancellationToken);
            }
        }
    }
}
