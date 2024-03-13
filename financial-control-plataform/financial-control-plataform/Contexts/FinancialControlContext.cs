using financial_control_plataform.Entities;
using financial_control_platform.Entities;
using Microsoft.EntityFrameworkCore;

namespace financial_control_plataform.Contexts
{
    public class FinancialControlContext : DatabaseContext
    {
        public FinancialControlContext(ILogger<FinancialControlContext> logger, DbContextOptions<FinancialControlContext> options) : base(logger, options)
        {
        }

        public DbSet<ExpensesIncomeType> ExpensesIncomeTypes { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersInstituitions> UsersInstitutions { get; set; }
        public DbSet<Instituitions> Institutions { get; set; }
        public DbSet<ExpensesIncome> ExpensesIncome { get; set; }
    }
}
