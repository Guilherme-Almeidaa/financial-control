using System.ComponentModel.DataAnnotations;

namespace financial_control_plataform.Entities
{
    public class Instituitions : Entity
    {
        [StringLength(40)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public TypeInstitution TypeInstitution { get; set; } = TypeInstitution.Physical;

        #region Foreign keys
        [Required]
        [ForeignKey(nameof(Users))]
        public Guid UserId { get; set; }
        public virtual Users Users { get; set; } = new Users();
        #endregion
    }
    public enum TypeInstitution
    {
        Legal,
        Physical
    }
}
