using FilterLists.Directory.Application.Validators;
using FilterLists.Directory.Infrastructure;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Directory.Application;

public static class ConfigurationExtensions
{
    public static IHostBuilder ConfigureApplication(this IHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureInfrastructure();
    }

    public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddInfrastructure(configuration);
        services.AddHttpClient();
        services.AddValidatorsFromAssembly(typeof(ConfigurationExtensions).Assembly, includeInternalTypes: true);
        services.AddAutoMapper(typeof(ConfigurationExtensions).Assembly);
        services.AddMediatR(typeof(ConfigurationExtensions).Assembly);
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidatorPipelineBehavior<,>));
    }

    public static void UseApplication(this IApplicationBuilder app)
    {
        app.UseInfrastructure();
    }
}
