using FluentValidation;
using Hellang.Middleware.ProblemDetails;
using ProblemDetailsOptions = Hellang.Middleware.ProblemDetails.ProblemDetailsOptions;

namespace FilterLists.Directory.Api;

internal static class ProblemDetailsConfigurationExtensions
{
    public static void ConfigureProblemDetails(this ProblemDetailsOptions options)
    {
        options.MapFluentValidationException();
        options.MapToStatusCode<NotImplementedException>(StatusCodes.Status501NotImplemented);
        options.MapToStatusCode<HttpRequestException>(StatusCodes.Status503ServiceUnavailable);
        options.MapToStatusCode<Exception>(StatusCodes.Status500InternalServerError);
    }

    private static void MapFluentValidationException(this ProblemDetailsOptions options)
    {
        options.Map<ValidationException>(
            (ctx, ex) =>
            {
                var factory = ctx.RequestServices.GetRequiredService<ProblemDetailsFactory>();
                var errors = ex.Errors
                    .GroupBy(f => f.PropertyName)
                    .ToDictionary(
                        g => g.Key,
                        g => g.Select(f => f.ErrorMessage)
                            .ToArray());
                return factory.CreateValidationProblemDetails(ctx, errors);
            });
    }
}
