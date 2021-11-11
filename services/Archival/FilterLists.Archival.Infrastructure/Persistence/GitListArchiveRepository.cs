﻿using System.Globalization;
using FilterLists.Archival.Domain.ListArchives;
using FilterLists.Archival.Infrastructure.Options;
using FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies;
using LibGit2Sharp;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FilterLists.Archival.Infrastructure.Persistence;

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
        var segmentNumber = 1;
        await foreach (var segment in listArchive.Segments.WithCancellation(cancellationToken))
        {
            var strategy = segment.GetStrategy<IStreamToPlainTextConversionStrategy>();
            if (strategy is default(IStreamToPlainTextConversionStrategy))
            {
                _logger.LogWarning(
                    "No stream to plain text conversion strategy found for extension {Extension} for list {ListId}. Skipping list",
                    segment.Extension,
                    listArchive.Id);
                return;
            }

            var fileInfo = GetTargetFile(listArchive.Id, segmentNumber, segment.Extension);
            if (fileInfo is default(FileInfo))
            {
                _logger.LogWarning(
                    "Writing from non-plain text extension {Extension} for list {ListId} not yet supported. Skipping list",
                    segment.Extension,
                    listArchive.Id);
                return;
            }

            _writtenFiles.Add(fileInfo);

            _logger.LogInformation("Writing {FileName}", fileInfo.Name);

            await using var target = fileInfo.OpenWrite();
            await strategy.Convert(segment, cancellationToken).CopyToAsync(target, cancellationToken);

            _logger.LogInformation("Finished writing {FileName}", fileInfo.Name);

            segmentNumber++;
        }
    }

    public void Commit()
    {
        if (_writtenFiles.Count > 0)
        {
            var fileNames = _writtenFiles.Select(f => f.Name).ToList();
            var signature = new Signature(_options.UserName, _options.UserEmail, DateTime.UtcNow);
            var message =
                $"feat(archives): archive {fileNames.Count} file(s){Environment.NewLine}{string.Join(Environment.NewLine, fileNames)}";
            Commands.Stage(_repo, fileNames);
            try
            {
                _repo.Commit(message, signature, signature);
            }
            catch (EmptyCommitException ex)
            {
                _logger.LogInformation(ex, "No changes to commit for {@FileNames}", fileNames);
            }

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

    private FileInfo? GetTargetFile(int listId, int segmentNumber, ListFileExtension extension)
    {
        string targetExtension;
        if (extension.IsPlainText)
        {
            targetExtension = extension.IsMeaningfulToConsumer ? extension.Value : ".txt";
        }
        else
        {
            // TODO: implement
            return default;
        }

        var targetFileName = GetTargetFileNamePrefix(listId) +
                             (segmentNumber == 1 ? string.Empty : $"-{segmentNumber}") +
                             targetExtension;
        return new FileInfo(Path.Combine(_options.RepositoryPath, targetFileName));
    }

    private static string GetTargetFileNamePrefix(int listId)
    {
        return listId.ToString(CultureInfo.InvariantCulture).PadLeft(5, '0');
    }
}
