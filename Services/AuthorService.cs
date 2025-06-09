using BookClub.Models;
using BookClub.DatabaseContext;
using Microsoft.EntityFrameworkCore;


namespace BookClub.Services;

public class AuthorService : IAuthorService
{
    private MyDatabaseContext _dbContext;

    public AuthorService(MyDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<IEnumerable<Author>> GetAllAuthors()
    {
        return await _dbContext.Authors.ToListAsync();
    }

    public async Task<Author?> GetAuthorById(Guid id)
    {
        Author? foundAuthor = await _dbContext.Authors.FindAsync(id);

        return foundAuthor;
    }
    public async Task<Author> CreateAuthor(CreateAuthor author)
    {
        Author convertedAuthor = new Author(author);

        await _dbContext.Authors.AddAsync(convertedAuthor);
        await _dbContext.SaveChangesAsync();

        return convertedAuthor;
    }

    public async Task<Author?> EditAuthor(Author author)
    {
        Author? foundAuthor = await _dbContext.Authors.FindAsync(author.Id);

        if (foundAuthor == null)
        {
            return foundAuthor;
        }

        foundAuthor.Name = author.Name;

        await _dbContext.SaveChangesAsync();

        return foundAuthor;
    }


    public async Task<Author?> DeleteAuthor(Guid id)
    {
        try
        {
            Author? foundAuthor = await _dbContext.Authors.FindAsync(id);

            if (foundAuthor is not null)
            {
                await _dbContext.Authors
                    .Where(a => a.Id == id)
                    .ExecuteDeleteAsync();
            }

            return foundAuthor;
        }
        catch (Exception e)
        {
            throw e;
        }
    }

}
