using Raven.Application.Contracts;
using Volo.Abp.Modularity;
namespace Raven.HttpApi.Client;
[DependsOn(
    typeof(RavenApplicationContractsModule)
)]
public class RavenHttpApiClientModule : AbpModule
{
}
