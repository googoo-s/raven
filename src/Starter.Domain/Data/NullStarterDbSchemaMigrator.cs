using Volo.Abp.DependencyInjection;

namespace Starter.Domain.Data;

public class NullStarterDbSchemaMigrator : IStarterDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}