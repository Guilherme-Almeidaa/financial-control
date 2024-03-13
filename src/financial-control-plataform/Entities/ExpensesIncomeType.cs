using System.ComponentModel.DataAnnotations;

namespace financial_control_plataform.Entities
{
    public class ExpensesIncomeType : Entity
    {
        [StringLength(40)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Description { get; set; } = string.Empty;

        [Required]
        public Operation Operation { get; set; } = Operation.Debit;
    }

    public enum Operation
    { 
        Credit,
        Debit
    }

}
