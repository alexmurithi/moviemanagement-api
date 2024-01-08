using MovieManagement.Domain.Common.Entity;

namespace MovieManagement.Domain.Entity
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; } = null!;

        public string? Name { get; set; }
        public string? Description { get; set; }

        public Actor? Actor { get; set; }

        public Guid ActorId { get; set; }

        public List<Genre>? Genre { get; set; }
    }
}
