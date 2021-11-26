using System.Text.Json;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Domain.Aggregates;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetChange
{
    public record Query(long Id) : IRequest<ChangeVm?>;

    internal class Handler : IRequestHandler<Query, ChangeVm?>
    {
        private readonly IQueryContext _context;
        private readonly IMapper _mapper;

        public Handler(IQueryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<ChangeVm?> Handle(Query request, CancellationToken cancellationToken)
        {
            return _context.Changes
                .Where(c => c.Id == request.Id)
                .ProjectTo<ChangeVm>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync(cancellationToken);
        }
    }

    internal class ChangesVmProfile : Profile
    {
        public ChangesVmProfile()
        {
            CreateMap<Change, ChangeVm>();
        }
    }

    public record ChangeVm
    {
        public long Id { get; private init; }
        public string? Reason { get; private init; }
        public DateTime SubmittedAt { get; private init; }
        public DateTime? ApprovedAt { get; private init; }
        public DateTime? RejectedAt { get; private init; }
        public string? RejectedReason { get; private init; }
        public JsonDocument? Before { get; private init; }
        public JsonDocument? After { get; private init; }
        public AggregateType AggregateType { get; private init; }
        public long? FilterListId { get; private init; }
        public long? LanguageId { get; private init; }
        public long? LicenseId { get; private init; }
        public long? MaintainerId { get; private init; }
        public long? SoftwareId { get; private init; }
        public long? SyntaxId { get; private init; }
        public long? TagId { get; private init; }
    }
}
