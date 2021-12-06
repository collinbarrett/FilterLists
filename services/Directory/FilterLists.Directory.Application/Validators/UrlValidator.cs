using FluentValidation;

namespace FilterLists.Directory.Application.Validators;

internal class UriValidator : AbstractValidator<Uri?>
{
    public UriValidator(IHttpClientFactory httpClientFactory)
    {
        RuleFor(u => u)
            .Cascade(CascadeMode.Stop)
            .Must(u => Uri.TryCreate(u?.OriginalString, UriKind.Absolute, out _))
            .WithMessage(u => $"Malformed absolute URL {u?.OriginalString}.")
            .CustomAsync(
                async (u, context, token) =>
                {
                    var response = default(HttpResponseMessage?);
                    try
                    {
                        response = await httpClientFactory.CreateClient()
                            .GetAsync(u, HttpCompletionOption.ResponseHeadersRead, token);
                    }
                    catch (HttpRequestException ex)
                    {
                        context.AddFailure($"Error accessing URL {u?.OriginalString}. {ex.Message}");
                    }
                    catch (InvalidOperationException ex)
                    {
                        context.AddFailure($"Error accessing URL {u?.OriginalString}. {ex.Message}");
                    }

                    if (response?.IsSuccessStatusCode != true)
                    {
                        context.AddFailure($"Error accessing URL {u?.OriginalString}. {response?.StatusCode}");
                    }
                })
            .When(u => u is not null);
    }
}
