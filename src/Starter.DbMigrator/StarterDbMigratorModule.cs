
using Starter.Application.Contracts;
using Starter.Domain;
using Starter.EntityFrameworkCore;

using Volo.Abp.Modularity;

namespace Starter;

[DependsOn(
    typeof(StarterDomainModule),
    typeof(StarterApplicationContractsModule),
    typeof(StarterEntityFrameworkCoreModule)
)]
public class StarterDbMigratorModule : AbpModule
{
}
