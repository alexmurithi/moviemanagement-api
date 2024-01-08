using ErrorOr;
using MovieManagement.Domain.Entity;

namespace MovieManagement.Application.Service
{
    public interface IActorService
    {
        public Task<IEnumerable<Actor>> GetAll();

        public ErrorOr<Actor?> GetActorById(Guid id);

        public Task<ErrorOr<Actor?>> GetActorByIdAsync(Guid id, CancellationToken cancellationToken = default);

    }
}
