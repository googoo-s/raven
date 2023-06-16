using Volo.Abp.Modularity;
using Starter.Domain.Shared;
namespace Starter.Application.Contracts;

[DependsOn(
    typeof(StarterDomainSharedModule)
)]
public class StarterApplicationContractsModule : AbpModule
{
}
