using Raven.Application.Contracts;
using Volo.Abp.Modularity;
namespace Raven.HttpApi;
[DependsOn(
    typeof(RavenApplicationContractsModule)
)]
public class RavenHttpApiModule : AbpModule
{
}
