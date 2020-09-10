using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Archival.Infrastructure.Options;
using LibGit2Sharp;
using Microsoft.Extensions.Options;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    internal class GitFileArchiver : IArchiveFile
    {
        private readonly GitOptions _options;
        private readonly IRepository _repository;

        public GitFileArchiver(IOptions<GitOptions> gitOptions, IRepository gitRepository)
        {
            _options = gitOptions.Value;
            _repository = gitRepository;
        }

        public async Task ArchiveFileAsync(
            Stream fileContents,
            string fileName,
            CancellationToken cancellationToken = default)
        {
            await using var output = File.OpenWrite(fileName);
            await fileContents.CopyToAsync(output, cancellationToken);
            if (!cancellationToken.IsCancellationRequested)
                Commit(fileName);
        }

        private void Commit(string fileName)
        {
            Commands.Stage(_repository, fileName);
            var utcNow = DateTime.UtcNow;
            var signature = new Signature(_options.UserName, _options.UserEmail, utcNow);
            var message = $"archive {fileName}";
            _repository.Commit(message, signature, signature);
        }
    }
}