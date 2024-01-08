using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MovieManagement.Application.Controllers
{
    [Route("/Error")]
    public class ErrorsController : ControllerBase
    {
        public IActionResult Error()
        {
             Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
             var instance = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Path;

            return Problem(
                title: exception?.Message,
                instance : instance
                );
        }
    }
}
