using Raven.Application.Contracts;
using Raven.Domain;
using Volo.Abp.Modularity;

namespace Raven.Application;

[DependsOn(
    typeof(RavenDomainModule),
    typeof(RavenApplicationContractsModule)
)]
public class RavenApplicationModule : AbpModule
{
}
