using financial_control_utils.Contexts.Interfaces;

namespace financial_control_utils.Contexts
{
    public class DatabaseContextFactory<TImplementation> : IDatabaseContextFactory
    where TImplementation : DatabaseContext, IDatabaseContext
    {
        private readonly IDbContextFactory<TImplementation> _databaseContextFactory;

        public DatabaseContextFactory(IDbContextFactory<TImplementation> databaseContextFactory)
        {
            _databaseContextFactory = databaseContextFactory;
        }

        public async Task<IDatabaseContext> CreateDbContextAsync(CancellationToken cancellationToken = default)
        {
            return await _databaseContextFactory.CreateDbContextAsync(cancellationToken);
        }
    }
}
