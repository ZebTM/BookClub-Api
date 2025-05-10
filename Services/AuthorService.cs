using BookClub.Models;
using BookClub.Repository;
namespace BookClub.Services;

public class AuthorService : IAuthorService
{
    private IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }


    public Task<IEnumerable<Author>> GetAllAuthors()
    {
        throw new NotImplementedException();
    }

    public Task<Author?> GetAuthorById(Guid id)
    {

        throw new NotImplementedException();
    }
    public Task<Author> CreateAuthor(Author author)
    {

        throw new NotImplementedException();
    }
    public Task<Author?> EditAuthor(Author author)
    {

        throw new NotImplementedException();
    }
    public Task<Author?> DeleteAuthor(Guid id)
    {

        throw new NotImplementedException();
    }

}
