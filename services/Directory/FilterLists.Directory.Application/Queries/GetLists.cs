using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Api.Contracts.Models;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetLists
{
    public record Query : IRequest<List<ListVm>>;

    internal class Handler : IRequestHandler<Query, List<ListVm>>
    {
        private readonly IQueryContext _context;
        private readonly IMapper _mapper;

        public Handler(IQueryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<ListVm>> Handle(
            Query request,
            CancellationToken cancellationToken)
        {
            return _context.FilterLists
                .OrderBy(fl => fl.Id)
                .ProjectTo<ListVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }

    internal class ListVmProfile : Profile
    {
        public ListVmProfile()
        {
            CreateMap<FilterList, ListVm>()
                .ForMember(fl => fl.SyntaxIds,
                    o => o.MapFrom(fl =>
                        fl.FilterListSyntaxes.OrderBy(fls => fls.SyntaxId).Select(fls => fls.SyntaxId)))
                .ForMember(fl => fl.Iso6391s,
                    o => o.MapFrom(fl =>
                        fl.FilterListLanguages.OrderBy(fll => fll.Iso6391).Select(fll => fll.Iso6391)))
                .ForMember(fl => fl.TagIds,
                    o => o.MapFrom(fl =>
                        fl.FilterListTags.OrderBy(flt => flt.TagId).Select(flt => flt.TagId)))
                .ForMember(fl => fl.PrimaryViewUrl,
                    o => o.MapFrom(fl =>
                        fl.ViewUrls.OrderBy(u => u.SegmentNumber).ThenBy(u => u.Primariness).Select(u => u.Url)
                            .FirstOrDefault()))
                .ForMember(fl => fl.MaintainerIds,
                    o => o.MapFrom(fl =>
                        fl.FilterListMaintainers.OrderBy(flm => flm.MaintainerId).Select(flm => flm.MaintainerId)));
        }
    }
}
