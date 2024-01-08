using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Common.Errors
{
    public static class Errors
    {
        public static class User
        {
            public static Error UserNotFound() => Error.NotFound(
                code: "User.NotFound",
                description: $"User with Id: Not Found!"
                );
        }
    }
}
     