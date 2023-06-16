using Starter.Application.Contracts;
using Starter.Domain;

using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Starter.Application;

[DependsOn(
    typeof(StarterDomainModule),
    typeof(StarterApplicationContractsModule),
    typeof(AbpAutoMapperModule)
)]
public class StarterApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
        Configure<AbpAutoMapperOptions>(options => options.AddMaps<StarterApplicationModule>());
    }
}
