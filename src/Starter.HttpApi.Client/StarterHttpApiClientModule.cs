using Volo.Abp.Modularity;
using Starter.Application.Contracts;
namespace Starter;
[DependsOn(
    typeof(StarterApplicationContractsModule)
)]
public class StarterHttpApiClientModule : AbpModule
{
}
