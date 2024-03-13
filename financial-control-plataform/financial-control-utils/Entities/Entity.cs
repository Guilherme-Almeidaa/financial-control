using System.ComponentModel.DataAnnotations;

namespace financial_control_utils.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public DateTime Created { get; set; } = DateTime.UtcNow;

        public DateTime? Updated { get; set; }

        public DateTime? Excluded { get; set; }
    }
}
