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
            private readonly IRepository _repository;

            public Handler(IOptions<ArchiveSettings> archiveOptions, IRepository repository)
            {
                _archiveSettings = archiveOptions.Value;
                _repository = repository;
            }

            protected override void Handle(Command request)
            {
                Commands.Stage(_repository, "*");
                var utcNow = DateTime.UtcNow;
                var signature = new Signature(_archiveSettings.SignatureName, _archiveSettings.SignatureEmail, utcNow);
                _repository.Commit(utcNow.ToShortDateString() + _archiveSettings.CommitMessageSuffix, signature,
                    signature);
            }
        }
    }
}