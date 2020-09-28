﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Archival.Domain.Lists;
using FilterLists.Archival.Infrastructure.Options;
using FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies;
using LibGit2Sharp;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    internal sealed class GitListArchiveRepository : IListArchiveRepository
    {
        private readonly ILogger _logger;
        private readonly GitOptions _options;
        private readonly IRepository _repo;
        private readonly ICollection<FileInfo> _writtenFiles = new HashSet<FileInfo>();

        public GitListArchiveRepository(
            ILogger<GitListArchiveRepository> logger,
            IOptions<GitOptions> gitOptions,
            IRepository repository)
        {
            _logger = logger;
            _options = gitOptions.Value;
            _repo = repository;
        }

        public async Task AddAsync(ListArchive listArchive, CancellationToken cancellationToken)
        {
            int segmentCount = 0;
            await foreach (var segment in listArchive.Segments.WithCancellation(cancellationToken))
            {
                var strategy = segment.GetStrategy<IStreamToPlainTextConversionStrategy>();
                if (strategy is default(IStreamToPlainTextConversionStrategy))
                {
                    _logger.LogWarning(
                        "No stream to plain text conversion strategy found for extension {Extension} for target {Target}. Skipping list",
                        segment.Extension,
                        listArchive.TargetFileName);
                    return;
                }

                string targetExtension;
                if (segment.Extension.IsPlainText)
                {
                    targetExtension = segment.Extension.IsMeaningfulToConsumer ? segment.Extension.Value : ".txt";
                }
                else
                {
                    // TODO: implement
                    _logger.LogWarning(
                        "Writing from non-plain text extension {Extension} for target {Target} not yet supported. Skipping list",
                        segment.Extension,
                        listArchive.TargetFileName);
                    return;
                }

                var targetFileName = listArchive.TargetFileName + (segmentCount == 0 ? string.Empty : $"-{segmentCount}") + targetExtension;
                var fileInfo = new FileInfo(Path.Combine(_options.RepositoryPath, targetFileName));
                _writtenFiles.Add(fileInfo);

                _logger.LogInformation("Writing {FileName}", fileInfo.Name);

                await using var target = fileInfo.OpenWrite();
                await segment.Content.CopyToAsync(target, cancellationToken);

                _logger.LogInformation("Finished writing {FileName}", fileInfo.Name);

                segmentCount++;
            }
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
