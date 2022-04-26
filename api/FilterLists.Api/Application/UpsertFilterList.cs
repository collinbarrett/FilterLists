using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;
using MediatR;

namespace FilterLists.Api.Application;

public static class UpsertFilterList
{
    public record Command : IRequest<ResponseVm>
    {
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
        public Uri? HomeUrl { get; init; }
        public Uri? OnionUrl { get; init; }
        public Uri? PolicyUrl { get; init; }
        public Uri? SubmissionUrl { get; init; }
        public Uri? IssuesUrl { get; init; }
        public Uri? ForumUrl { get; init; }
        public Uri? ChatUrl { get; init; }
        public string? EmailAddress { get; init; }
        public Uri? DonateUrl { get; init; }
        public IEnumerable<FilterListViewUrl> ViewUrls { get; init; } = new HashSet<FilterListViewUrl>();
        public License License { get; init; } = default!;
        public IEnumerable<Syntax> Syntaxes { get; init; } = new HashSet<Syntax>();
        public IEnumerable<string> LanguageIso6391s { get; init; } = new HashSet<string>();
        public IEnumerable<Maintainer> Maintainers { get; init; } = new HashSet<Maintainer>();
        public IEnumerable<Tag> Tags { get; init; } = new HashSet<Tag>();
        public IEnumerable<string> UpstreamFilterListNames { get; init; } = new HashSet<string>();
        public IEnumerable<string> ForkFilterListNames { get; init; } = new HashSet<string>();
        public IEnumerable<string> IncludedInFilterListNames { get; init; } = new HashSet<string>();
        public IEnumerable<string> IncludesFilterListNames { get; init; } = new HashSet<string>();
        public IEnumerable<string> DependencyFilterListNames { get; init; } = new HashSet<string>();
        public IEnumerable<string> DependentFilterListNames { get; init; } = new HashSet<string>();
    }

    public record FilterListViewUrl
    {
        public int SegmentNumber { get; init; }
        public int Primariness { get; init; }
        public Uri Url { get; init; } = default!;
    }

    public record License
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Url { get; init; }
        public bool PermitsModification { get; init; }
        public bool PermitsDistribution { get; init; }
        public bool PermitsCommercialUse { get; init; }
    }

    public record Maintainer
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public Uri? Url { get; init; }
        public string? EmailAddress { get; init; }
        public string? TwitterHandle { get; init; }
    }

    public record Software
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
        public Uri? HomeUrl { get; init; }
        public Uri? DownloadUrl { get; init; }
        public bool SupportsAbpUrlScheme { get; init; }
    }

    public record Syntax
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
        public Uri? Url { get; init; }
        public IEnumerable<Software> Software { get; init; } = new HashSet<Software>();
    }

    public record Tag
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
    }

    public class Handler : IRequestHandler<Command, ResponseVm>
    {
        private readonly TableClient _tableClient;

        public Handler(TableServiceClient tableServiceClient)
        {
            _tableClient = tableServiceClient.GetTableClient(TableStorageConstants.FilterListsTableName);
        }

        public async Task<ResponseVm> Handle(Command request, CancellationToken cancellationToken)
        {
            // if no approval token
                // log to pending changes
            // else
                // upsert
                // update any changed child entities on other lists

            return await Task.FromResult(new ResponseVm());
        }
    }

    public record ResponseVm
    {
    }
}