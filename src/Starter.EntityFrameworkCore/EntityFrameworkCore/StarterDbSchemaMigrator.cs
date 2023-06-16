using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Starter.Domain.Data;
using Starter.EntityFrameworkCore.EntityFrameworkCore;

using Volo.Abp.DependencyInjection;

public class StarterDbSchemaMigrator : IStarterDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public StarterDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    public async Task MigrateAsync()
    {
        /* We intentionally resolving the StarterDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StarterDbContext>()
            .Database
            .MigrateAsync();
    }
}