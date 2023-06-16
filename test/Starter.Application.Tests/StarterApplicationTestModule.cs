using Starter.Application;

using Volo.Abp.Modularity;

namespace Starter.Application;

[DependsOn(
    typeof(StarterApplicationModule),
    typeof(StarterDomainTestModule)
    )]
public class StarterApplicationTestModule : AbpModule
{
}
