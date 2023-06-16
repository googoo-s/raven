using Raven.Application.Contracts;
using Raven.Domain;
using Raven.EntityFrameworkCore;
using Volo.Abp.Modularity;
namespace Raven.DbMigrator;

[DependsOn(
    typeof(RavenDomainModule),
    typeof(RavenApplicationContractsModule),
    typeof(RavenEntityFrameworkCoreModule)
)]
public class RavenDbMigratorModule : AbpModule
{
}
