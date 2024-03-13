using financial_control_plataform.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace financial_control_platform.Entities
{
    public class ExpensesIncome : Entity
    {
        [Required]
        public float Value { get; set; }

        [StringLength(40)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        [Required]
        public string Description { get; set; } = string.Empty;

        public int? Frequency { get; set; }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value.Date; } // Isso ajusta a hora para meia-noite, efetivamente ignorando a hora.
        }

        [Required]
        public bool Fixed { get; set; } = false;
        public bool Settled { get; set; } = false;

        #region Foreign keys
        [Required]
        [ForeignKey(nameof(ExpensesIncomeType))]
        public Guid ExpenseIncomeTypeId { get; set; }
        public virtual ExpensesIncomeType ExpenseIncomeType { get; set; } = new ExpensesIncomeType();

        [Required]
        [ForeignKey(nameof(Instituitions))]
        public Guid InstituitionId { get; set; }
        public virtual Instituitions Instituition { get; set; } = new Instituitions();
        #endregion
    }

}
