﻿using System;
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
    public static class GetLicenses
    {
        public class Query : IRequest<IEnumerable<LicenseViewModel>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<LicenseViewModel>>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IEnumerable<LicenseViewModel>> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.Licenses
                    .OrderBy(l => l.Id)
                    .ProjectTo<LicenseViewModel>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
        }

        public class LicenseViewModelProfile : Profile
        {
            public LicenseViewModelProfile()
            {
                CreateMap<License, LicenseViewModel>()
                    .ForMember(l => l.FilterListIds,
                        o => o.MapFrom(l =>
                            l.FilterLists.Select(fl => fl.Id).OrderBy(flid => flid)));
            }
        }

        public class LicenseViewModel
        {
            public int Id { get; private set; }
            public string Name { get; private set; } = null!;
            public Uri? Url { get; private set; }
            public bool PermitsModification { get; private set; }
            public bool PermitsDistribution { get; private set; }
            public bool PermitsCommercialUse { get; private set; }
            public IEnumerable<int>? FilterListIds { get; private set; }
        }
    }
}