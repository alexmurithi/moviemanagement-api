using MovieManagement.Domain.Common.Entity;

namespace MovieManagement.Domain.Entity
{
    public class Actor : BaseEntity
    {
        public string FirstName { get; set; } = null!;

        public string? LastName { get; set;}

        public List<Movie>? Movies { get; set; }

        public Biography? Biography { get; set; }
    }
}
