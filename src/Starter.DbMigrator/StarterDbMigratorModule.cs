using Starter.Application.Contracts;
using Starter.Domain;
using Starter.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Starter.DbMigrator;

[DependsOn(
    typeof(StarterDomainModule),
    typeof(StarterApplicationContractsModule),
    typeof(StarterEntityFrameworkCoreModule),
    typeof(AbpAutofacModule)
)]
public class StarterDbMigratorModule : AbpModule
{
}
