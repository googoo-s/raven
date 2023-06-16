namespace Starter.Domain.Data;

public interface IStarterDbSchemaMigrator
{
    Task MigrateAsync();
}
