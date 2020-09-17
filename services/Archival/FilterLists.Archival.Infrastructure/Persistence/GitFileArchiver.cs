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
            CancellationToken cancellationToken = default)
        {
            var strategy = file.GetStrategy<IFileWriteStrategy>();
            if (strategy is default(IFileWriteStrategy))
            {
                _logger.LogWarning(
                    "No write strategy found for {Filename}. Skipping",
                    file.Target.Name);
            }
            else
            {
                _logger.LogDebug(
                    "Writing {Filename} with strategy {FileWriteStrategy}",
                    file.Target.Name,
                    strategy.GetType().Name);

                _writtenFiles.Add(file.Target);

                // TODO: write to _options.RepositoryPath
                await strategy.WriteAsync(file, cancellationToken);

                _logger.LogDebug("Finished writing {Filename}", file.Target.Name);
            }
        }

        public void Commit()
        {
            var filenames = _writtenFiles.Select(f => f.Name).ToList();
            Commands.Stage(_repo, filenames);
            var signature = new Signature(_options.UserName, _options.UserEmail, DateTime.UtcNow);
            var message =  $"feat(archives): archive {filenames.Count} files{Environment.NewLine}{string.Join(Environment.NewLine, filenames)}";
            _repo.Commit(message, signature, signature);

            _logger.LogDebug("Committed {@Filenames}", filenames);
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
