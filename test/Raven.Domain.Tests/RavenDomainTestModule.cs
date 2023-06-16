using Raven.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Raven;

[DependsOn(
    typeof(RavenEntityFrameworkCoreTestModule)
    )]
public class RavenDomainTestModule : AbpModule
{

}
