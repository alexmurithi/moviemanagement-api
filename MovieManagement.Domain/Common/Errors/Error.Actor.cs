using ErrorOr;

namespace MovieManagement.Domain.Common.Errors
{
    public static partial class Errors
    {
        public static class Actor
        {
            public static Error ActorNotFound(Guid id) => Error.NotFound(
                code: "Actor.NotFound",
                description: $"Actor with id:{id} not found!"
                );
        }
    }
}
     