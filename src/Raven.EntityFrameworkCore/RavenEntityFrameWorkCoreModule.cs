using Volo.Abp.Modularity;
using Raven.Domain;
using Volo.Abp.EntityFrameworkCore.MySQL;

namespace Raven.EntityFrameworkCore;

[DependsOn(
    typeof(RavenDomainModule),
    typeof(AbpEntityFrameworkCoreMySQLModule)
)]
public class RavenEntityFrameWorkCoreModule : AbpModule
{
}