using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Starter.Domain.Data;

public class StarterDataSeederContributor : IDataSeedContributor, ITransientDependency
{
    public Task SeedAsync(DataSeedContext context)
    {
        throw new NotImplementedException();

        // todo 数据种子
    }
}