using System;
using LibGit2Sharp;
using MediatR;

namespace FilterLists.Agent.Application.Archiver
{
    public static class CommitDownloadedLists
    {
        public class Command : IRequest
        {
        }

        public class Handler : RequestHandler<Command>
        {
            private const string GitRepoDirectory = @"archives";

            protected override void Handle(Command request)
            {
                if (!Repository.IsValid(GitRepoDirectory))
                    Repository.Init(GitRepoDirectory);
                using (var repo = new Repository(GitRepoDirectory))
                {
                    Commands.Stage(repo, "*");
                    var utcNow = DateTime.UtcNow;
                    var signature = new Signature("FilterLists.Agent", "noreply@filterlists.com", utcNow);
                    repo.Commit(utcNow.ToShortDateString() + " FilterLists archive by FilterLists.Agent", signature, signature);
                }
            }
        }
    }
}