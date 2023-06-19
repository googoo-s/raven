using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Services;
using Volo.Abp.Guids;
namespace Starter.Domain.Authors;
public class AuthorManager : DomainService
{
    private readonly IAuthorRepository _authorRepository;

    private readonly IGuidGenerator _guidGenerator;

    public AuthorManager(IAuthorRepository authorRepository,
        IGuidGenerator guidGenerator)
    {
        _authorRepository = authorRepository;
        _guidGenerator = guidGenerator;
    }

    public async Task<Author> CreateAsync(
        [NotNull] string name,
        DateTime birthDate,
        [CanBeNull] string shortBio = null)
    {
        Check.NotNullOrWhiteSpace(name, nameof(name));

        var existingAuthor = await _authorRepository.FindByNameAsync(name);
        if (existingAuthor != null)
        {
            throw new AuthorAlreadyExistsException(name);
        }

        return new Author(
            _guidGenerator.Create(),
            name,
            birthDate,
            shortBio
        );
    }

    public async Task ChangeNameAsync(
        [NotNull] Author author,
        [NotNull] string newName)
    {
        Check.NotNull(author, nameof(author));
        Check.NotNullOrWhiteSpace(newName, nameof(newName));

        var existingAuthor = await _authorRepository.FindByNameAsync(newName);
        if (existingAuthor != null && existingAuthor.Id != author.Id)
        {
            throw new AuthorAlreadyExistsException(newName);
        }

        author.ChangeName(newName);
    }
}