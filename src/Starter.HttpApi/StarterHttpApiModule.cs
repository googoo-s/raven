using Volo.Abp.Modularity;
using Volo.Abp.AutoMapper;
using Starter.Application.Contracts;

namespace Starter;
[DependsOn(
    typeof(StarterApplicationContractsModule),
    typeof(AbpAutoMapperModule)
)]
public class StarterHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
        Configure<AbpAutoMapperOptions>(options => options.AddMaps<StarterHttpApiModule>());
    }
}
