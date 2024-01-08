using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entity;

namespace MovieManagement.Infrastructure.Context
{
    public class MovieManagementDbContext : DbContext
    {
        public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext> options) : base(options) { } 

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Biography> Biographies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Actor>()
                .HasData(
                    new Actor{ Id = Guid.NewGuid(),FirstName = "Justin",LastName = "Timberlake", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
                    new Actor { Id = Guid.NewGuid(), FirstName = "Chuck", LastName = "Norris", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                    new Actor { Id = Guid.NewGuid(), FirstName = "Van", LastName = "Damme", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                );
        }
    }
}
