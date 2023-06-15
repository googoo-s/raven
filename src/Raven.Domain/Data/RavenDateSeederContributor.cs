using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Raven.Domain.Data;

public class RavenDataSeederContributor : IDataSeedContributor, ITransientDependency
{
    public Task SeedAsync(DataSeedContext context)
    {
        throw new NotImplementedException();

        // todo 数据种子
    }
}