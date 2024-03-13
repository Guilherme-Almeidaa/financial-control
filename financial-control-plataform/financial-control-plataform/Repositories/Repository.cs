using financial_control_plataform.Repositories.Interfaces;
using financial_control_utils.Contexts.Interfaces;
using System.Linq.Expressions;

namespace financial_control_plataform.Repositories
{
    public sealed class Repository<T> : IRepository<T> where T : Entity 
    {
        private readonly IDatabaseContext _databaseContext;
        public Repository(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate,
        bool descending = false,
        Expression<Func<T, dynamic>>? orderBy = null,
        CancellationToken cancellationToken = default)
        {
            var queryable = _databaseContext.Set<T>()
                .Where(predicate);

            if (orderBy is not null)
            {
                queryable = descending ? queryable.OrderByDescending(orderBy) : queryable.OrderBy(orderBy);
            }

            return await queryable
                .FirstOrDefaultAsync(cancellationToken);
        }
    }
}
