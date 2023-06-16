using Volo.Abp.Modularity;

namespace Starter;

[DependsOn(
    typeof(StarterApplicationModule),
    typeof(StarterDomainTestModule)
    )]
public class StarterApplicationTestModule : AbpModule
{
}
