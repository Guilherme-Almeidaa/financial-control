using financial_control_utils.Contexts.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace financial_control_utils.Contexts
{
    public class DatabaseContext :DbContext , IDatabaseContext
    {
        private readonly ILogger<IDatabaseContext> _logger;

        private bool _disposable;

        protected DatabaseContext(ILogger<IDatabaseContext> logger,
            DbContextOptions options) : base(options)
        {
            _logger = logger;
        }
    }
}
