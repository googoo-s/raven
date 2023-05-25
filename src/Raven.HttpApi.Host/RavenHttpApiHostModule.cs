using Raven.Application;
using Raven.EntityFrameworkCore;
using Volo.Abp.Modularity;
namespace Raven.HttpApi.Client;

[DependsOn(
    typeof(RavenApplicationModule),
    typeof(RavenEntityFrameWorkCoreModule),
    typeof(RavenHttpApiModule)
)]
public class RavenHttpApiHostModule : AbpModule
{
}
