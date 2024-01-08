using MovieManagement.Domain.Entity;
using MovieManagement.Domain.Repository;
using MovieManagement.Infrastructure.Common.Repository;
using MovieManagement.Infrastructure.Context;

namespace MovieManagement.Infrastructure.Repository
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(MovieManagementDbContext dbContext) : base(dbContext) { }
    }
}
