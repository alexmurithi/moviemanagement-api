using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace MovieManagement.Application.Filter
{
    public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
           
            var problemDetails = new ProblemDetails
            {
                Title = "An error occured while processing your request!",
                Instance = context.HttpContext.Request.Path,
                Status = (int) HttpStatusCode.InternalServerError,
                Detail = context.Exception.Message
            };
            context.Result = new ObjectResult(problemDetails);
            context.ExceptionHandled = true;
        }
    }
}
