using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Api.Contracts.Models;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetListDetails
{
    public record Query(int Id) : IRequest<ListDetailsVm?>;

    internal class Validator : AbstractValidator<Query>
    {
        public Validator()
        {
            RuleFor(q => q.Id)
                .GreaterThanOrEqualTo(0);
        }
    }

    internal class Handler : IRequestHandler<Query, ListDetailsVm?>
    {
        private readonly IQueryContext _context;
        private readonly IMapper _mapper;

        public Handler(IQueryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<ListDetailsVm?> Handle(
            Query request,
            CancellationToken cancellationToken)
        {
            return _context.FilterLists
                .ProjectTo<ListDetailsVm>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync(fl => fl.Id == request.Id, cancellationToken);
        }
    }

    internal class ListDetailsVmProfile : Profile
    {
        public ListDetailsVmProfile()
        {
            CreateMap<FilterList, ListDetailsVm>()
                .ForMember(fl => fl.SyntaxIds,
                    o => o.MapFrom(fl =>
                        fl.FilterListSyntaxes.OrderBy(fls => fls.SyntaxId).Select(fls => fls.SyntaxId)))
                .ForMember(fl => fl.Iso6391s,
                    o => o.MapFrom(fl =>
                        fl.FilterListLanguages.OrderBy(fll => fll.Iso6391).Select(fll => fll.Iso6391)))
                .ForMember(fl => fl.TagIds,
                    o => o.MapFrom(fl =>
                        fl.FilterListTags.OrderBy(flt => flt.TagId).Select(flt => flt.TagId)))
                .ForMember(fl => fl.ViewUrls,
                    o => o.MapFrom(fl =>
                        fl.ViewUrls.OrderBy(u => u.SegmentNumber).ThenBy(u => u.Primariness)))
                .ForMember(fl => fl.MaintainerIds,
                    o => o.MapFrom(fl =>
                        fl.FilterListMaintainers.OrderBy(flm => flm.MaintainerId).Select(flm => flm.MaintainerId)))
                .ForMember(fl => fl.UpstreamFilterListIds,
                    o => o.MapFrom(fl =>
                        fl.UpstreamFilterLists.OrderBy(f => f.UpstreamFilterListId)
                            .Select(f => f.UpstreamFilterListId)))
                .ForMember(fl => fl.ForkFilterListIds,
                    o => o.MapFrom(fl =>
                        fl.ForkFilterLists.OrderBy(f => f.ForkFilterListId).Select(f => f.ForkFilterListId)))
                .ForMember(fl => fl.IncludedInFilterListIds,
                    o => o.MapFrom(fl =>
                        fl.IncludedInFilterLists.OrderBy(m => m.IncludedInFilterListId)
                            .Select(m => m.IncludedInFilterListId)))
                .ForMember(fl => fl.IncludesFilterListIds,
                    o => o.MapFrom(fl =>
                        fl.IncludesFilterLists.OrderBy(m => m.IncludesFilterListId)
                            .Select(m => m.IncludesFilterListId)))
                .ForMember(fl => fl.DependencyFilterListIds,
                    o => o.MapFrom(fl =>
                        fl.DependencyFilterLists.OrderBy(d => d.DependencyFilterListId)
                            .Select(d => d.DependencyFilterListId)))
                .ForMember(fl => fl.DependentFilterListIds,
                    o => o.MapFrom(fl =>
                        fl.DependentFilterLists.OrderBy(d => d.DependentFilterListId)
                            .Select(d => d.DependentFilterListId)));

            CreateMap<FilterListViewUrl, ListDetailsVm.ViewUrlVm>();
        }
    }
}
