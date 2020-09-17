﻿using System;
using Hangfire;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace FilterLists.Archival.Infrastructure.Scheduling
{
    internal static class ConfigurationExtensions
    {
        private static ConnectionMultiplexer _redis = null!;

        public static void AddSchedulingServices(this IServiceCollection services, IConfiguration configuration)
        {
            _redis = ConnectionMultiplexer.Connect(configuration.GetConnectionString("SchedulingConnection"));
            services.AddHangfire((provider, globalConfiguration) =>
            {
                var mediator = provider.GetService<IMediator>();
                globalConfiguration.UseRedisStorage(_redis).UseMediatR(mediator);
            });
        }

        public static void UseScheduling(this IApplicationBuilder app)
        {
            // TODO: re-evaluate git in parallel
            app.UseHangfireServer(new BackgroundJobServerOptions {WorkerCount = 1});
        }
    }
}
