using financial_control_plataform.Entities;
using Microsoft.EntityFrameworkCore;

namespace financial_control_plataform.Contexts
{
    public class FinancialControlContext : DatabaseContext
    {
        public FinancialControlContext(ILogger<FinancialControlContext> logger, DbContextOptions<FinancialControlContext> options) : base(logger, options)
        {
        }

        public DbSet<ExpensesIncomeType> ExpensesIncomeTypes { get; set; }
    }
}
