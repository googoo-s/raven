using Volo.Abp.DependencyInjection;

namespace Raven.Domain.Data;

public class NullRavenDbSchemaMigrator : IRavenDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}