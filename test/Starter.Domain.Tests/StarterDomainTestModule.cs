using Starter.EntityFrameworkCore.EntityFrameworkCore;

using Volo.Abp.Modularity;

namespace Starter.Domain;

[DependsOn(
    typeof(StarterEntityFrameworkCoreTestModule)
    )]
public class StarterDomainTestModule : AbpModule
{
}
