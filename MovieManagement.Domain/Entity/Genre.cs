
using MovieManagement.Domain.Common.Entity;

namespace MovieManagement.Domain.Entity
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; } = null!;

        public List<Movie>? Movies { get; set; }
    }
}
