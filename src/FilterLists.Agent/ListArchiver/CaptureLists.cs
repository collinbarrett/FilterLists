using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Entities;
using FilterLists.Agent.Infrastructure;
using LibGit2Sharp;
using MediatR;
using RestSharp;

namespace FilterLists.Agent.ListArchiver
{
    public static class CaptureLists
    {
        public class Command : IRequest
        {
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private readonly IFilterListsApiClient _apiClient;
            private readonly IMediator _mediator;

            public Handler(IFilterListsApiClient apiClient, IMediator mediator)
            {
                _apiClient = apiClient;
                _mediator = mediator;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                const string workingDirectoryPath = @"archives";

                var lists = await GetListInfo();
                await _mediator.Send(new DownloadLists.Command(lists), cancellationToken);


                using (var repo = new Repository(workingDirectoryPath))
                {
                    Commands.Stage(repo, "*");
                    var author = new Signature("James", "@jugglingnutcase", DateTime.UtcNow);
                    var committer = author;
                    var commit = repo.Commit("Here's a commit i made!", author, committer);
                }
            }

            private async Task<IEnumerable<ListInfo>> GetListInfo()
            {
                var listsRequest = new RestRequest("lists");
                return await _apiClient.ExecuteAsync<IEnumerable<ListInfo>>(listsRequest);
            }
        }
    }
}