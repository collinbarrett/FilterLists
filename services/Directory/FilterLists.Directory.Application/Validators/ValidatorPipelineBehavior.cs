using FluentValidation;
using MediatR;

namespace FilterLists.Directory.Application.Validators;

internal class ValidatorPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidatorPipelineBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        CancellationToken cancellationToken,
        RequestHandlerDelegate<TResponse> next)
    {
        await Task.WhenAll(_validators.Select(v => v.ValidateAndThrowAsync(request, cancellationToken)));
        return await next();
    }
}
