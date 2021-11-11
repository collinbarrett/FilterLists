using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Directory.Api.Controllers;

[ApiController]
[ApiExplorerSettings(IgnoreApi = true)]
// TODO: de-duplicate into SharedKernel
public class ErrorController : ControllerBase
{
    [Route("/error-local-development")]
    public IActionResult ErrorLocalDevelopment([FromServices] IWebHostEnvironment webHostEnvironment)
    {
        if (webHostEnvironment.EnvironmentName != "Development")
        {
            throw new InvalidOperationException("This shouldn't be invoked in non-development environments.");
        }

        var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
        return Problem(context?.Error.StackTrace, title: context?.Error.Message);
    }

    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}
