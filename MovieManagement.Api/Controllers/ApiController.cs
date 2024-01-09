﻿using ErrorOr;
using Microsoft.AspNetCore.Mvc;

namespace MovieManagement.Application.Controllers
{
    [ApiController]
    public class ApiController : ControllerBase
    {
        protected ActionResult Problem(List<Error> errors) 
        {
           var firstError = errors[0];

        var statusCode = firstError.Type switch 
        {
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            ErrorType.Unauthorized => StatusCodes.Status401Unauthorized,
            _ => StatusCodes.Status500InternalServerError
        };

        return Problem(
            statusCode: statusCode, 
            title: firstError.Description
            );
        }

    }
}
