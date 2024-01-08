
using MovieManagement.Domain.Common.Entity;

namespace MovieManagement.Domain.Entity
{
    public class Biography : BaseEntity
    {
        public string? Description { get; set; }

        public Actor? Actor { get; set; }
        
        public Guid ActorId { get; set; }
    }
}
