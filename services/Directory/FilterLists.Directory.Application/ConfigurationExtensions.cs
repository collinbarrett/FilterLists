﻿using AutoMapper;
using FilterLists.Directory.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Directory.Application
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
            services.AddAutoMapper(typeof(ConfigurationExtensions));
            services.AddInfrastructureServices(configuration);
        }

        public static void UseApplication(this IApplicationBuilder app)
        {
            app.UseInfrastructure();
        }
    }
}
