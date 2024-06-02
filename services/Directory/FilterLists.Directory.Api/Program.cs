using FilterLists.Directory.Infrastructure;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.Services.AddProblemDetails();
builder.AddInfrastructureForDirectoryApi();

var app = builder.Build();

app.UseExceptionHandler();

app.MapGet("/lists",
    (IQueryContext queryContext) =>
    {
        return queryContext
            .FilterLists
            .Select(f => new
            {
                f.Id,
                f.Name,
                f.Description,
                f.LicenseId,
                SyntaxIds = f.FilterListSyntaxes
                    .OrderBy(fls => fls.SyntaxId)
                    .Select(fls => fls.SyntaxId),
                LanguageIds = f.FilterListLanguages
                    .OrderBy(fll => fll.LanguageId)
                    .Select(fll => fll.LanguageId),
                TagIds = f.FilterListTags
                    .OrderBy(flt => flt.TagId)
                    .Select(flt => flt.TagId),
                PrimaryViewUrl = f.ViewUrls
                    .OrderBy(u => u.SegmentNumber)
                    .ThenBy(u => u.Primariness)
                    .Select(u => u.Url)
                    .FirstOrDefault(),
                MaintainerIds = f.FilterListMaintainers
                    .OrderBy(flm => flm.MaintainerId)
                    .Select(flm => flm.MaintainerId)
            })
            .AsAsyncEnumerable();
    });

app.MapDefaultEndpoints();

app.Run();