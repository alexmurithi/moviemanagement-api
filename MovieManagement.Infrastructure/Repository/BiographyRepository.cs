using MovieManagement.Domain.Entity;
using MovieManagement.Domain.Repository;
using MovieManagement.Infrastructure.Common.Repository;
using MovieManagement.Infrastructure.Context;

namespace MovieManagement.Infrastructure.Repository
{
    public class BiographyRepository : GenericRepository<Biography>, IBiographyRepository
    {
        public BiographyRepository(MovieManagementDbContext dbContext) : base(dbContext) { }
    }
}
