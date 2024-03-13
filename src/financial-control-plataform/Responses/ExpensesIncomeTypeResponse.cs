using financial_control_plataform.Entities;

namespace financial_control_plataform.Responses
{
    public record ExpensesIncomeTypeResponse(Guid Id, string Name, Operation Operation,string? Description);
}
