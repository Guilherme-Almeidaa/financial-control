using System.ComponentModel.DataAnnotations;

namespace financial_control_plataform.Entities
{
    public class Users : Entity
    {

        [StringLength(40)]
        [Required]
        public string UserName { get; set; } = string.Empty;

        [StringLength(40)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [StringLength(40)]
        [Required]
        public string LastName { get; set; } = string.Empty;

        [StringLength(40)]
        [Required]
        public string Email { get; set; } = string.Empty;

        [StringLength(12)]
        [Required]
        public string ContactNumber { get; set; } = string.Empty;
        public virtual Instituitions Instituitions { get; set; } = new Instituitions();
    }
}
