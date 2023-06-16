using Starter.Domain.Shared;

using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Starter;
[DependsOn(
    typeof(StarterDomainSharedModule),
    typeof(AbpAutoMapperModule)
)]
public class StarterDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
        Configure<AbpAutoMapperOptions>(options => options.AddMaps<StarterDomainModule>());
    }
}
