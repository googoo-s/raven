using Raven.Domain.Shared;

using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Raven.Domain;
[DependsOn(
    typeof(RavenDomainSharedModule),
    typeof(AbpAutoMapperModule)
)]
public class RavenDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
        Configure<AbpAutoMapperOptions>(options => options.AddMaps<RavenDomainModule>());
    }
}
