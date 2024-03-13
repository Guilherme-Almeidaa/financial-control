using System.ComponentModel.DataAnnotations;

namespace financial_control_plataform.Entities
{
    public class UsersInstituitions : Entity
    {
        [Required]

        [ForeignKey(nameof(Users))]
        public Guid UserId { get; set; }
        public virtual Users User { get; set; } = new Users();

        [Required]

        [ForeignKey(nameof(Instituitions))]
        public Guid InstituitionId { get; set; }
        public virtual Instituitions Instituition { get; set; } = new Instituitions();
    }
}
