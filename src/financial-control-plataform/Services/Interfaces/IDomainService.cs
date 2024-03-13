using System.Linq.Expressions;

namespace financial_control_plataform.Services.Interfaces
{
    public interface IDomainService<T> where T : Entity
    {
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate,
        bool descending = false,
        Expression<Func<T, dynamic>>? orderBy = default,
        CancellationToken cancellationToken = default);
    }
}
