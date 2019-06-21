﻿using AutoMapper;
using FilterLists.Data;
using FilterLists.Services.FilterList;
using FilterLists.Services.GitHub;
using FilterLists.Services.Language;
using FilterLists.Services.License;
using FilterLists.Services.Maintainer;
using FilterLists.Services.Seed;
using FilterLists.Services.Snapshot;
using FilterLists.Services.Software;
using FilterLists.Services.Syntax;
using FilterLists.Services.Tag;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FilterLists.Services.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static void AddFilterListsApiServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton(c => config);
            services.AddEntityFrameworkMySql()
                    .AddDbContextPool<FilterListsDbContext>(o =>
                        o.UseMySql(config.GetConnectionString("FilterListsConnection"),
                            m =>
                            {
                                m.EnableRetryOnFailure(5);
                                m.MigrationsAssembly("FilterLists.Api");
                            }));
            services.TryAddScoped<FilterListService>();
            services.TryAddScoped<LanguageService>();
            services.TryAddScoped<LicenseService>();
            services.TryAddScoped<MaintainerService>();
            services.TryAddScoped<SeedService>();
            services.TryAddScoped<SoftwareService>();
            services.TryAddScoped<SyntaxService>();
            services.TryAddScoped<TagService>();
            services.TryAddScoped<RuleService>();
            services.AddAutoMapper(typeof(Service));
        }

        public static void AddFilterListsAgentServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton(c => config);
            services.AddEntityFrameworkMySql()
                    .AddDbContextPool<FilterListsDbContext>(o =>
                        o.UseMySql(config.GetConnectionString("FilterListsConnection"),
                            m =>
                            {
                                m.EnableRetryOnFailure(5);
                                m.MigrationsAssembly("FilterLists.Api");
                            }));
            services.TryAddScoped<GitHubService>();
            services.TryAddScoped<SnapshotService>();
            services.TryAddScoped<Logger>();
            services.AddAutoMapper(typeof(Service));
        }
    }
}