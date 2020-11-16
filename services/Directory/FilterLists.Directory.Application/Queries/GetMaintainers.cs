using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries
{
    public static class GetMaintainers
    {
        public class Query : IRequest<IEnumerable<MaintainerVm>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<MaintainerVm>>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IEnumerable<MaintainerVm>> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.Maintainers
                    .OrderBy(m => m.Id)
                    .ProjectTo<MaintainerVm>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
        }

        public class MaintainerVmProfile : Profile
        {
            public MaintainerVmProfile()
            {
                CreateMap<Maintainer, MaintainerVm>()
                    .ForMember(m => m.FilterListIds,
                        o => o.MapFrom(m =>
                            m.FilterListMaintainers.Select(flm => flm.FilterListId).OrderBy(flid => flid).AsEnumerable()));
            }
        }

        public class MaintainerVm
        {
            public int Id { get; private set; }
            public string Name { get; private set; } = null!;
            public Uri? Url { get; private set; }
            public string? EmailAddress { get; private set; }
            public string? TwitterHandle { get; private set; }
            public IEnumerable<int>? FilterListIds { get; private set; }
        }
    }
}
