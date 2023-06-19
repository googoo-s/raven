using System.Linq.Dynamic.Core;

using Microsoft.EntityFrameworkCore;
using Starter.Domain.Authors;
using Starter.EntityFrameworkCore.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Starter.EntityFrameworkCore.Authors;
public class EfCoreAuthorRepository
    : EfCoreRepository<StarterDbContext, Author, Guid>,
        IAuthorRepository
{
    public EfCoreAuthorRepository(
        IDbContextProvider<StarterDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }

    public async Task<Author> FindByNameAsync(string name)
    {
        var dbSet = await GetDbSetAsync();
        return await dbSet.FirstOrDefaultAsync(author => author.Name == name);
    }

    public async Task<List<Author>> GetListAsync(
        int skipCount,
        int maxResultCount,
        string sorting,
        string filter = null)
    {
        var dbSet = await GetDbSetAsync();
        return await dbSet
            .WhereIf(
                !filter.IsNullOrWhiteSpace(),
                author => author.Name.Contains(filter)
             )
            .OrderBy(sorting)
            .Skip(skipCount)
            .Take(maxResultCount)
            .ToListAsync();
    }
}
