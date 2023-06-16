using Starter.Application.Contracts;

using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Starter.HttpApi;
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
