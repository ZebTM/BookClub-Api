using BookClub.Models;
using BookClub.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace BookClub.Repository;

public class AuthorRepository : IAuthorRepository, IDisposable
{
    private MyDatabaseContext _dbContext;

    public AuthorRepository(MyDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Author>> GetAllAuthors()
    {
        throw new NotImplementedException();
    }

    public async Task<Author> CreateAuthor(Author author)
    {
        throw new NotImplementedException();
    }


    public async Task<Author?> InsertAuthor(Author author)
    {
        throw new NotImplementedException();


    }


    public async Task<Author?> DeleteAuthor(Guid id)
    {
        throw new NotImplementedException();

    }


    public async Task<Author?> EditAuthor(Author author)
    {
        throw new NotImplementedException();

    }

    public void Dispose()
    {

    }
}


