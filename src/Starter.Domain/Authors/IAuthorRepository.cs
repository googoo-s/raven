using Volo.Abp.Domain.Repositories;

namespace Starter.Domain.Authors;
public interface IAuthorRepository : IRepository<Author, Guid>
{
    Task<Author> FindByNameAsync(string name);

    Task<List<Author>> GetListAsync(
        int skipCount,
        int maxResultCount,
        string sorting,
        string filter = null
    );
}