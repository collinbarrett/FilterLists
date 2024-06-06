using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using JetBrains.Annotations;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace FilterLists.Directory.Api.OpenApi;

internal static class OpenApiTags
{
    internal static readonly OpenApiTag LanguagesTag = new()
    {
        Name = nameof(QueryDbContext.Languages),
        Description = "A written form of communication used by sites targeted by a FilterList",
        ExternalDocs = new OpenApiExternalDocs
        {
            Description = $"{nameof(FilterLists)} {nameof(Language)} Wiki",
            Url = new Uri($"https://github.com/collinbarrett/FilterLists/wiki/{nameof(Language)}")
        }
    };

    internal static readonly OpenApiTag LicensesTag = new()
    {
        Name = nameof(QueryDbContext.Licenses),
        Description = "A legal document governing the use or redistribution of a FilterList",
        ExternalDocs = new OpenApiExternalDocs
        {
            Description = $"{nameof(FilterLists)} {nameof(License)} Wiki",
            Url = new Uri($"https://github.com/collinbarrett/FilterLists/wiki/{nameof(License)}")
        }
    };

    internal static readonly OpenApiTag FilterListsTag = new()
    {
        Name = nameof(QueryDbContext.FilterLists),
        Description = "A text file containing a list of rules for blocking or manipulating internet traffic",
        ExternalDocs = new OpenApiExternalDocs
        {
            Description = $"{nameof(FilterLists)} {nameof(FilterList)} Wiki",
            Url = new Uri($"https://github.com/collinbarrett/FilterLists/wiki/{nameof(FilterList)}")
        }
    };

    internal static readonly OpenApiTag MaintainersTag = new()
    {
        Name = nameof(QueryDbContext.Maintainers),
        Description = "An individual, group, or organization who maintains one or more FilterLists",
        ExternalDocs = new OpenApiExternalDocs
        {
            Description = $"{nameof(FilterLists)} {nameof(Maintainer)} Wiki",
            Url = new Uri($"https://github.com/collinbarrett/FilterLists/wiki/{nameof(Maintainer)}")
        }
    };

    internal static readonly OpenApiTag SoftwareTag = new()
    {
        Name = nameof(QueryDbContext.Software),
        Description = "An application, browser extension, or other utility that consumes FilterLists",
        ExternalDocs = new OpenApiExternalDocs
        {
            Description = $"{nameof(FilterLists)} {nameof(Software)} Wiki",
            Url = new Uri($"https://github.com/collinbarrett/FilterLists/wiki/{nameof(Software)}")
        }
    };

    internal static readonly OpenApiTag SyntaxesTag = new()
    {
        Name = nameof(QueryDbContext.Syntaxes),
        Description = "A named set of rules that govern the format of a FilterList",
        ExternalDocs = new OpenApiExternalDocs
        {
            Description = $"{nameof(FilterLists)} {nameof(Syntax)} Wiki",
            Url = new Uri($"https://github.com/collinbarrett/FilterLists/wiki/{nameof(Syntax)}")
        }
    };

    internal static readonly OpenApiTag TagsTag = new()
    {
        Name = nameof(QueryDbContext.Tags),
        Description =
            "A generic taxonomy applied to a FilterList to provide information about its contents and/or purpose",
        ExternalDocs = new OpenApiExternalDocs
        {
            Description = $"{nameof(FilterLists)} {nameof(Tag)} Wiki",
            Url = new Uri($"https://github.com/collinbarrett/FilterLists/wiki/{nameof(Tag)}")
        }
    };

    [UsedImplicitly]
    internal sealed class TagDescriptionsDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Tags =
            [
                LanguagesTag,
                LicensesTag,
                FilterListsTag,
                MaintainersTag,
                SoftwareTag,
                SyntaxesTag,
                TagsTag
            ];
        }
    }
}