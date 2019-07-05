using System;
using FilterLists.Agent.AppSettings;
using LibGit2Sharp;
using MediatR;
using Microsoft.Extensions.Options;

namespace FilterLists.Agent.Features.Lists
{
    public static class CommitLists
    {
        public class Command : IRequest
        {
        }

        public class Handler : RequestHandler<Command>
        {
            private readonly ArchiveSettings _archiveSettings;

            public Handler(IOptions<ArchiveSettings> archiveSettings)
            {
                _archiveSettings = archiveSettings.Value;
            }

            protected override void Handle(Command request)
            {
                if (!Repository.IsValid(_archiveSettings.RepositoryDirectory))
                    Repository.Init(_archiveSettings.RepositoryDirectory);
                using (var repo = new Repository(_archiveSettings.RepositoryDirectory))
                {
                    Commands.Stage(repo, "*");
                    var utcNow = DateTime.UtcNow;
                    var signature = new Signature(_archiveSettings.SignatureName, _archiveSettings.SignatureEmail,
                        utcNow);
                    repo.Commit(utcNow.ToShortDateString() + _archiveSettings.CommitMessageSuffix, signature,
                        signature);
                }
            }
        }
    }
}