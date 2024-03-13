namespace financial_control_utils.Contexts.Interfaces
{
    public interface IDatabaseContextFactory
    {
        Task<IDatabaseContext> CreateDbContextAsync(CancellationToken cancellationToken = default);
    }
}
