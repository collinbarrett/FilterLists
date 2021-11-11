﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetSyntaxes
{
    public class Query : IRequest<IEnumerable<SyntaxVm>>
    {
    }

    internal class Handler : IRequestHandler<Query, IEnumerable<SyntaxVm>>
    {
        private readonly IQueryContext _context;
        private readonly IMapper _mapper;

        public Handler(IQueryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SyntaxVm>> Handle(
            Query request,
            CancellationToken cancellationToken)
        {
            return await _context.Syntaxes
                .OrderBy(s => s.Id)
                .ProjectTo<SyntaxVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }

    internal class SyntaxVmProfile : Profile
    {
        public SyntaxVmProfile()
        {
            CreateMap<Syntax, SyntaxVm>()
                .ForMember(s => s.FilterListIds,
                    o => o.MapFrom(s =>
                        s.FilterListSyntaxes.Select(sls => sls.FilterListId).OrderBy(flid => flid).AsEnumerable()))
                .ForMember(s => s.SoftwareIds,
                    o => o.MapFrom(s =>
                        s.SoftwareSyntaxes.Select(ss => ss.SoftwareId).OrderBy(sid => sid).AsEnumerable()));
        }
    }

    public class SyntaxVm
    {
        public int Id { get; init; }
        public string Name { get; init; } = null!;
        public string? Description { get; init; }
        public Uri? Url { get; init; }
        public IEnumerable<int>? FilterListIds { get; init; }
        public IEnumerable<int>? SoftwareIds { get; init; }
    }
}
