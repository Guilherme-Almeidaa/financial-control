using financial_control_plataform.Repositories.Interfaces;
using financial_control_plataform.Services.Interfaces;
using System.Linq.Expressions;

namespace financial_control_plataform.Services
{
    public class DomainService<T> : IDomainService<T> where T : Entity
    {
        private readonly IRepository<T> _repository;

        public DomainService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate,
        bool descending = false,
        Expression<Func<T, dynamic>>? orderBy = null,
        CancellationToken cancellationToken = default)
        {
            return await _repository.GetAsync(predicate, descending, orderBy, cancellationToken);
        }
    }
}
