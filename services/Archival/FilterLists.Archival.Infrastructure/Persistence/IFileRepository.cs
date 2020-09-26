using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Archival.Infrastructure.Options;
using FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies;
using FilterLists.Archival.Infrastructure.SeedWork;
using LibGit2Sharp;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    public interface IFileRepository : IUnitOfWork
    {
        Task AddFileAsync(IFile file, CancellationToken cancellationToken);
    }

    internal sealed class GitFileRepository : IFileRepository
    {
        private readonly ILogger _logger;
        private readonly GitOptions _options;
        private readonly IRepository _repo;
        private readonly ICollection<FileInfo> _writtenFiles = new HashSet<FileInfo>();

        public GitFileRepository(
            ILogger<GitFileRepository> logger,
            IOptions<GitOptions> gitOptions,
            IRepository repository)
        {
            _logger = logger;
            _options = gitOptions.Value;
            _repo = repository;
        }

        public async Task AddFileAsync(IFile file, CancellationToken cancellationToken)
        {
            var textStreams = new List<Stream>();
            await foreach (var segment in file.Segments.WithCancellation(cancellationToken))
            {
                var strategy = segment.GetStrategy<IStreamToTxtConversionStrategy>();
                if (strategy is default(IStreamToTxtConversionStrategy))
                {
                    _logger.LogWarning(
                        "No stream to txt conversion strategy found for extension {Extension} for target {Target}. Skipping file",
                        segment.SourceExtension,
                        file.TargetFileName);
                    return;
                }

                textStreams.Add(strategy.Convert(segment, cancellationToken));
            }

            _logger.LogInformation("Writing {FileName}", file.TargetFileName);

            var fileInfo = new FileInfo(Path.Combine(_options.RepositoryPath, file.TargetFileName));
            _writtenFiles.Add(fileInfo);
            await using var target = fileInfo.OpenWrite();

            // TODO: validate multi-segment lists are concatenated correctly and in order
            foreach (var textStream in textStreams)
            {
                await textStream.CopyToAsync(target, cancellationToken);
            }

            _logger.LogInformation("Finished writing {FileName}", file.TargetFileName);
        }

        public void Commit()
        {
            if (_writtenFiles.Count > 0)
            {
                var fileNames = _writtenFiles.Select(f => f.Name).ToList();
                var signature = new Signature(_options.UserName, _options.UserEmail, DateTime.UtcNow);
                var message = $"feat(archives): archive {fileNames.Count} file(s){Environment.NewLine}{string.Join(Environment.NewLine, fileNames)}";
                Commands.Stage(_repo, fileNames);
                _repo.Commit(message, signature, signature);

                _logger.LogInformation("Committed {@FileNames}", fileNames);
            }
            else
            {
                _logger.LogInformation("No written files to commit");
            }
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
