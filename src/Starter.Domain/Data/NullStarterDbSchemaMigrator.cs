using Starter.Data;
using Volo.Abp.DependencyInjection;

namespace Starter.Data;

public class NullStarterDbSchemaMigrator : IStarterDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}