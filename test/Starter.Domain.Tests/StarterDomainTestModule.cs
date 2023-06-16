using Volo.Abp.Modularity;
using Starter.EntityFrameworkCore;


namespace Starter;

[DependsOn(
    typeof(StarterEntityFrameworkCoreTestModule)
    )]
public class StarterDomainTestModule : AbpModule
{
}
