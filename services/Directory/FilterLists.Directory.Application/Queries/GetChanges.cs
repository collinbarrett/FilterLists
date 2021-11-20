using System.Text.Json;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Domain.Aggregates;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetChanges
{
    public record Query : IRequest<List<ChangesVm>>;

    internal class Handler : IRequestHandler<Query, List<ChangesVm>>
    {
        private readonly IQueryContext _context;
        private readonly IMapper _mapper;

        public Handler(IQueryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<ChangesVm>> Handle(Query request, CancellationToken cancellationToken)
        {
            return _context.Changes
                .Where(c => c.ApprovedAt == null && c.RejectedAt == null)
                .OrderBy(c => c.SubmittedAt)
                .ProjectTo<ChangesVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }

    internal class ChangesVmProfile : Profile
    {
        public ChangesVmProfile()
        {
            CreateMap<Change, ChangesVm>();
        }
    }

    public record ChangesVm
    {
        public int Id { get; private init; }
        public string? Reason { get; private init; }
        public DateTime SubmittedAt { get; private init; }
        public DateTime? ApprovedAt { get; private init; }
        public DateTime? RejectedAt { get; private init; }
        public string? RejectedReason { get; private init; }
        public JsonDocument? Before { get; private init; }
        public JsonDocument? After { get; private init; }
        public AggregateType AggregateType { get; private init; }
        public int? FilterListId { get; private init; }
        public FilterList? FilterList { get; }
        public string? LanguageIso6391 { get; private init; }
        public Language? Language { get; }
        public int? LicenseId { get; private init; }
        public License? License { get; }
        public int? MaintainerId { get; private init; }
        public Maintainer? Maintainer { get; }
        public int? SoftwareId { get; private init; }
        public Software? Software { get; }
        public int? SyntaxId { get; private init; }
        public Syntax? Syntax { get; }
        public int? TagId { get; private init; }
        public Tag? Tag { get; }
    }
}
