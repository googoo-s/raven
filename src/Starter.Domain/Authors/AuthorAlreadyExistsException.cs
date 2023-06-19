using Starter.Domain.Shared;

using Volo.Abp;

namespace Starter.Domain.Authors;
public class AuthorAlreadyExistsException : BusinessException
{
    public AuthorAlreadyExistsException(string name) : base(BookStoreDomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}