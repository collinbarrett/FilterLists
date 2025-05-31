using FilterLists.Directory.Application.Queries;
using FilterLists.Directory.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Directory.Application;

public static class ConfigurationExtensions
{
    public static void AddApplication(this IHostApplicationBuilder builder)
    {
        builder.AddInfrastructure();
        builder.Services.AddScoped<GetLanguages.Query>();
        builder.Services.AddScoped<GetLicenses.Query>();
        builder.Services.AddScoped<GetListDetails.Query>();
        builder.Services.AddScoped<GetLists.Query>();
        builder.Services.AddScoped<GetMaintainers.Query>();
        builder.Services.AddScoped<GetSoftware.Query>();
        builder.Services.AddScoped<GetSyntaxes.Query>();
        builder.Services.AddScoped<GetTags.Query>();
    }
}