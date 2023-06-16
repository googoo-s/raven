namespace Starter.Data;

public interface IStarterDbSchemaMigrator
{
    Task MigrateAsync();
}
