using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetLanguages
{
    public class Query : IRequest<IEnumerable<LanguageVm>>
    {
    }

    internal class Handler : IRequestHandler<Query, IEnumerable<LanguageVm>>
    {
        private readonly IQueryContext _context;
        private readonly IMapper _mapper;

        public Handler(IQueryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LanguageVm>> Handle(
            Query request,
            CancellationToken cancellationToken)
        {
            return await _context.Languages
                .Where(l => l.FilterListLanguages.Any())
                .OrderBy(l => l.Iso6391)
                .ProjectTo<LanguageVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }

    internal class LanguageVmProfile : Profile
    {
        public LanguageVmProfile()
        {
            CreateMap<Language, LanguageVm>()
                .ForMember(l => l.FilterListIds,
                    o => o.MapFrom(l =>
                        l.FilterListLanguages.Select(fll => fll.FilterListId).OrderBy(flid => flid)
                            .AsEnumerable()));
        }
    }

    public class LanguageVm
    {
        public string Iso6391 { get; init; } = null!;
        public string Name { get; init; } = null!;
        public IEnumerable<int>? FilterListIds { get; init; }
    }
}
