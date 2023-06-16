using Raven.Application;
using Volo.Abp.Modularity;

namespace Raven;

[DependsOn(
    typeof(RavenApplicationModule),
    typeof(RavenDomainTestModule)
    )]
public class RavenApplicationTestModule : AbpModule
{
}
