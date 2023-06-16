using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Raven.Domain.Data;

using Volo.Abp.DependencyInjection;

namespace Raven.EntityFrameworkCore.EntityFrameworkCore;

public class RavenDbSchemaMigrator : IRavenDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public RavenDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BookStoreDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<RavenDbContext>()
            .Database
            .MigrateAsync();
    }
}