using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Archival.Infrastructure.Options;
using LibGit2Sharp;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FilterLists.Archival.Infrastructure.Persistence
{
#pragma warning disable CA1812
    internal class GitFileArchiver : IArchiveFiles
#pragma warning restore CA1812
    {
        private readonly IList<string> _filePaths = new List<string>();
        private readonly ILogger<GitFileArchiver> _logger;
        private readonly GitOptions _options;
        private readonly IRepository _repository;

        public GitFileArchiver(
            ILogger<GitFileArchiver> logger,
            IOptions<GitOptions> gitOptions,
            IRepository gitRepository)
        {
            _logger = logger;
            _options = gitOptions.Value;
            _repository = gitRepository;
        }

        public async Task ArchiveFileAsync(
            Stream fileContents,
            string filePath,
            CancellationToken cancellationToken = default)
        {
            _logger.LogInformation($"Archiving {filePath}");

            _filePaths.Add(filePath);
            await using var output = File.OpenWrite(filePath);
            await fileContents.CopyToAsync(output, cancellationToken);

            _logger.LogInformation($"Archived {filePath}");
        }

        public void Commit()
        {
            Commands.Stage(_repository, _filePaths);
            var signature = new Signature(_options.UserName, _options.UserEmail, DateTime.UtcNow);
            var message = $"feat(archives): archive {_filePaths.Count} files{Environment.NewLine}{string.Join(Environment.NewLine, _filePaths)}";
            _repository.Commit(message, signature, signature);

            _logger.LogInformation($"Committed {string.Join(",", _filePaths)}");
        }

        public void Dispose()
        {
            foreach (var file in _filePaths)
                if (File.Exists(file))
                    File.Delete(file);
            _repository.CheckoutPaths("HEAD", _filePaths);
        }
    }
}