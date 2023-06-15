using Raven.Application.Contracts;
using Volo.Abp.Modularity;
using Volo.Abp.AutoMapper;
namespace Raven.HttpApi;
[DependsOn(
    typeof(RavenApplicationContractsModule),
    typeof(AbpAutoMapperModule)
)]
public class RavenHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
        Configure<AbpAutoMapperOptions>(options => options.AddMaps<RavenHttpApiModule>());
    }
}
