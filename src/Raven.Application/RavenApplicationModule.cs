using Raven.Application.Contracts;
using Raven.Domain;

using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Raven.Application;

[DependsOn(
    typeof(RavenDomainModule),
    typeof(RavenApplicationContractsModule),
    typeof(AbpAutoMapperModule)
)]
public class RavenApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
        Configure<AbpAutoMapperOptions>(options => options.AddMaps<RavenApplicationModule>());
    }
}
