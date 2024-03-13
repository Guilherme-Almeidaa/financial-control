using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace financial_control_utils.Contexts.Interfaces
{
    public interface IDatabaseContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
