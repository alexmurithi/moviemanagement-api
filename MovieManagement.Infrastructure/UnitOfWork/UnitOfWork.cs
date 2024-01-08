using MovieManagement.Domain.Repository;
using MovieManagement.Domain.UnitOfWork;
using MovieManagement.Infrastructure.Context;
using MovieManagement.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieManagementDbContext _dbContext;

        private IActorRepository _actorRepository = null!;

        private IMovieRepository _movieRepository = null!;

        private IGenreRepository _genreRepository = null!;

        private IBiographyRepository _biographyRepository = null!;

        public UnitOfWork(MovieManagementDbContext dbContext)  => _dbContext = dbContext;
        public IActorRepository ActorRepository
        {
            get { return _actorRepository = _actorRepository ?? new ActorRepository(_dbContext); }
        }

        public IMovieRepository MovieRepository
        {
            get { return _movieRepository = _movieRepository ?? new MovieRepository(_dbContext); }
        }

        public IBiographyRepository BiographyRepository 
        {
            get { return _biographyRepository = _biographyRepository ?? new BiographyRepository(_dbContext); }
        }

        public IGenreRepository GenreRepository 
        {
            get { return _genreRepository = _genreRepository ?? new GenreRepository(_dbContext); }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async  Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void RollBack()
        {
            _dbContext.Dispose();
        }

        public async Task RollbackAsync()
        {
            await _dbContext.DisposeAsync();
        }
    }
}
