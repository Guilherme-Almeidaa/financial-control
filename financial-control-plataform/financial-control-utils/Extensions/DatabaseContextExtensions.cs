using financial_control_utils.Contexts.Interfaces;
using financial_control_utils.Contexts;


namespace financial_control_utils.Extensions;

[ExcludeFromCodeCoverage]
public static class DatabaseContextExtensions
{
    public static IServiceCollection AddDbContextDependencies<TService, TImplementation>(
        this IServiceCollection services, string connectionString)
        where TService : class, IDatabaseContext
        where TImplementation : DatabaseContext, TService
    {
        return services.AddDbContextFactory<TImplementation>((_, options) =>
        {
            options.UseNpgsql(connectionString)
                .UseSnakeCaseNamingConvention()
                .UseLazyLoadingProxies();
        })
            .AddSingleton<IDatabaseContextFactory>(service =>
            {
                var implementation = service.GetRequiredService<IDbContextFactory<TImplementation>>();

                return new DatabaseContextFactory<TImplementation>(implementation);
            })
            .AddScoped<TService, TImplementation>(service =>
            {
                var factory = service.GetRequiredService<IDbContextFactory<TImplementation>>();
                var context = factory.CreateDbContext();

                return context;
            });
    }
}
