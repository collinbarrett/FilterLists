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

            public async Task<IEnumerable<ListViewModel>> Handle(Query request,
                CancellationToken cancellationToken)
            {
                return await _context.FilterLists
                    .Select(fl => new ListViewModel
                    {
                        Id = default,
                        Name = fl.Name,
                        Description = fl.Description,
                        LicenseId = default,
                        SyntaxId = default,
                        LanguageIds = default,
                        TagIds = default,
                        ViewUrl = default,
                        ViewUrlMirrors = default,
                        HomeUrl = default,
                        PolicyUrl = default,
                        SubmissionUrl = default,
                        IssuesUrl = default,
                        ForumUrl = default,
                        ChatUrl = default,
                        EmailAddress = default,
                        DonateUrl = default,
                        MaintainerIds = default
                    })
                    .ToListAsync(cancellationToken);
            }
        }

        public class ListViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string? Description { get; set; }
            public int? LicenseId { get; set; }
            public int? SyntaxId { get; set; }
            public IEnumerable<int> LanguageIds { get; set; }
            public IEnumerable<int> TagIds { get; set; }
            public string ViewUrl { get; set; }
            public IEnumerable<string> ViewUrlMirrors { get; set; }
            public string HomeUrl { get; set; }
            public string PolicyUrl { get; set; }
            public string SubmissionUrl { get; set; }
            public string IssuesUrl { get; set; }
            public string ForumUrl { get; set; }
            public string ChatUrl { get; set; }
            public string EmailAddress { get; set; }
            public string DonateUrl { get; set; }
            public IEnumerable<int> MaintainerIds { get; set; }
        }
    }
}