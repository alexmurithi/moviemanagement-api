using MovieManagement.Domain.Entity;
using MovieManagement.Domain.Repository;
using MovieManagement.Infrastructure.Common.Repository;
using MovieManagement.Infrastructure.Context;

namespace MovieManagement.Infrastructure.Repository
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(MovieManagementDbContext dbContext) : base(dbContext) { }
    }
}
