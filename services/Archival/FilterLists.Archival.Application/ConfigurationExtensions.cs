﻿using FilterLists.Archival.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Archival.Application
{
    public static class ConfigurationExtensions
    {
        public static IHostBuilder UseApplication(this IHostBuilder hostBuilder)
        {
            return hostBuilder.UseInfrastructure();
        }

        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(ConfigurationExtensions).Assembly);
            services.AddInfrastructureServices(configuration);
        }

        public static void UseApplication(this IApplicationBuilder app)
        {
            app.UseInfrastructure();
        }
    }
}
