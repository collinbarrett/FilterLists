using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Archival.Infrastructure.Options;
using FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies;
using LibGit2Sharp;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    internal sealed class GitFileArchiver : IFileArchiver
    {
        private readonly ILogger _logger;
        private readonly GitOptions _options;
        private readonly IRepository _repo;
        private readonly ICollection<FileInfo> _writtenFiles = new HashSet<FileInfo>();

        public GitFileArchiver(
            ILogger<GitFileArchiver> logger,
            IOptions<GitOptions> gitOptions,
            IRepository repository)
        {
            _logger = logger;
            _options = gitOptions.Value;
            _repo = repository;
        }

        public async Task ArchiveFileAsync(
            IFileToArchive file,
            CancellationToken cancellationToken)
        {
            var textStreams = new List<Stream>();
            await foreach (var segment in file.Segments.WithCancellation(cancellationToken))
            {
                var strategy = segment.GetStrategy<IFileStreamConversionStrategy>();
                if (strategy is default(IFileStreamConversionStrategy))
                {
                    _logger.LogWarning(
                        "No file stream conversion strategy found for extension {Extension} in target {Target}. Skipping file",
                        segment.SourceExtension,
                        file.Target);
                    return;
                }

                textStreams.Add(strategy.Convert(segment, cancellationToken));
            }

            _logger.LogDebug("Writing {FileName}", file.Target.Name);

            _writtenFiles.Add(file.Target);

            // TODO: write to _options.RepositoryPath
            await using var target = file.Target.OpenWrite();
            foreach (var textStream in textStreams)
            {
                await textStream.CopyToAsync(target, cancellationToken);
            }

            _logger.LogDebug("Finished writing {FileName}", file.Target.Name);
        }

        public void Commit()
        {
            var fileNames = _writtenFiles.Select(f => f.Name).ToList();
            Commands.Stage(_repo, fileNames);
            var signature = new Signature(_options.UserName, _options.UserEmail, DateTime.UtcNow);
            var message = $"feat(archives): archive {fileNames.Count} files{Environment.NewLine}{string.Join(Environment.NewLine, fileNames)}";
            _repo.Commit(message, signature, signature);

            _logger.LogDebug("Committed {@FileNames}", fileNames);
        }

        public void Dispose()
        {
            foreach (var file in _writtenFiles)
            {
                if (File.Exists(file.Name))
                {
                    File.Delete(file.Name);
                }
            }

            _repo.CheckoutPaths("HEAD", _writtenFiles.Select(f => f.Name));
        }
    }
}
