
using MovieManagement.Domain.Repository;

namespace MovieManagement.Domain.UnitOfWork
{
    public interface IUnitOfWork 
    {
        IActorRepository ActorRepository { get; }

        IMovieRepository MovieRepository { get; }

        IGenreRepository GenreRepository { get; }

        IBiographyRepository BiographyRepository { get; }
        void Commit();

        void RollBack();

        Task CommitAsync();
        Task RollbackAsync();
    }
}
