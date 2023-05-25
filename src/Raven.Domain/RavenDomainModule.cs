using Raven.Domain.Shared;

using Volo.Abp.Modularity;

namespace Raven.Domain;
[DependsOn(
    typeof(RavenDomainSharedModule)
)]
public class RavenDomainModule : AbpModule
{
}
