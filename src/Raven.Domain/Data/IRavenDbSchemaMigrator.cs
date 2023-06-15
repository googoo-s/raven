using System.Threading.Tasks;

namespace Raven.Domain.Data;

public interface IRavenDbSchemaMigrator
{
    Task MigrateAsync();
}
