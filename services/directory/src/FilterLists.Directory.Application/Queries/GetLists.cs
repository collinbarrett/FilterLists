using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries
{
    public static class GetLists
    {
        public class Query : IRequest<IEnumerable<ListViewModel>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<ListViewModel>>
        {
            private readonly IQueryContext _context;

            public Handler(IQueryContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<ListViewModel>> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.FilterLists
                    .Select(fl => new ListViewModel
                    {
                        Id = fl.Id,
                        Name = fl.Name,
                        Description = fl.Description,
                        LicenseId = fl.License == null
                            ? default
                            : fl.License.Id,
                        SyntaxId = fl.FilterListSyntaxes.Any()
                            ? fl.FilterListSyntaxes.First().Syntax.Id
                            : default,
                        LanguageIds = fl.FilterListLanguages.Select(fll => fll.Language.Iso6391),
                        TagIds = fl.FilterListTags.Select(flt => flt.Tag.Id),
                        ViewUrl = fl.SegmentViewUrls.Any()
                            ? fl.SegmentViewUrls.OrderBy(s => s.Position).First().Url
                            : default,
                        ViewUrlMirrors = fl.SegmentViewUrls.Any()
                            ? fl.SegmentViewUrls.OrderBy(s => s.Position)
                                .First()
                                .SegmentViewUrlMirrors
                                .Select(m => m.Url)
                            : default,
                        HomeUrl = fl.HomeUrl,
                        PolicyUrl = fl.PolicyUrl,
                        SubmissionUrl = fl.SubmissionUrl,
                        IssuesUrl = fl.IssuesUrl,
                        ForumUrl = fl.ForumUrl,
                        ChatUrl = fl.ChatUrl,
                        EmailAddress = fl.EmailAddress,
                        DonateUrl = fl.DonateUrl,
                        MaintainerIds = fl.FilterListMaintainers.Select(flm => flm.Maintainer.Id)
                    })
                    .ToListAsync(cancellationToken);
            }
        }

        public class ListViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; } = null!;
            public string? Description { get; set; }
            public int? LicenseId { get; set; }
            public int? SyntaxId { get; set; }
            public IEnumerable<string>? LanguageIds { get; set; }
            public IEnumerable<int>? TagIds { get; set; }
            public Uri? ViewUrl { get; set; }
            public IEnumerable<Uri>? ViewUrlMirrors { get; set; }
            public Uri? HomeUrl { get; set; }
            public Uri? PolicyUrl { get; set; }
            public Uri? SubmissionUrl { get; set; }
            public Uri? IssuesUrl { get; set; }
            public Uri? ForumUrl { get; set; }
            public Uri? ChatUrl { get; set; }
            public string? EmailAddress { get; set; }
            public Uri? DonateUrl { get; set; }
            public IEnumerable<int>? MaintainerIds { get; set; }
        }
    }
}