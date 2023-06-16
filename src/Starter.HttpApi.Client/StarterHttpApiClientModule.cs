using Starter.Application.Contracts;

using Volo.Abp.Modularity;

namespace Starter.HttpApi.Client;
[DependsOn(
    typeof(StarterApplicationContractsModule)
)]
public class StarterHttpApiClientModule : AbpModule
{
}
