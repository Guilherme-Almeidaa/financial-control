namespace financial_control_utils.Contexts.Interfaces
{
    public interface IUnitOfWorkerContext : IDatabaseContext, IAsyncDisposable
    {
        Task BeginTransactionAsync(CancellationToken cancellationToken = default);

        Task CommitTransactionAsync(CancellationToken cancellationToken = default);

        Task RollbackTransactionAsync(CancellationToken cancellationToken = default);
    }
}
