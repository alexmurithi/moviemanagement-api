using MovieManagement.Domain.Entity;
using MovieManagement.Domain.Repository;
using MovieManagement.Infrastructure.Common.Repository;
using MovieManagement.Infrastructure.Context;

namespace MovieManagement.Infrastructure.Repository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieManagementDbContext dbContext) : base(dbContext) { }
    }
}
