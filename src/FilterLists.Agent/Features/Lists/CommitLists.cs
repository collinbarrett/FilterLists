using System;
using LibGit2Sharp;
using MediatR;

namespace FilterLists.Agent.Features.Lists
{
    public static class CommitLists
    {
        public class Command : IRequest
        {
        }

        public class Handler : RequestHandler<Command>
        {
            private const string RepoDirectory = "archives";
            private const string SignatureName = "FilterLists.Agent";
            private const string SignatureEmail = "noreply@filterlists.com";
            private const string CommitMessageSuffix = " FilterLists archive by FilterLists.Agent";

            protected override void Handle(Command request)
            {
                if (!Repository.IsValid(RepoDirectory))
                    Repository.Init(RepoDirectory);
                using (var repo = new Repository(RepoDirectory))
                {
                    Commands.Stage(repo, "*");
                    var utcNow = DateTime.UtcNow;
                    var signature = new Signature(SignatureName, SignatureEmail, utcNow);
                    repo.Commit(utcNow.ToShortDateString() + CommitMessageSuffix, signature, signature);
                }
            }
        }
    }
}