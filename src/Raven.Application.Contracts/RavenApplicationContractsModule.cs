using Raven.Domain.Shared;
using Volo.Abp.Modularity;
namespace Raven.Application.Contracts;

[DependsOn(
    typeof(RavenDomainSharedModule)
)]
public class RavenApplicationContractsModule : AbpModule
{
}
