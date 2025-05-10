using BookClub.Models;

namespace BookClub.Repository;

public interface IAuthorRepository : IDisposable
{
    Task<IEnumerable<Author>> GetAllAuthors();
    Task<Author> CreateAuthor(Author author);
    Task<Author?> InsertAuthor(Author author);
    Task<Author?> DeleteAuthor(Guid id);
    Task<Author?> EditAuthor(Author author);
}
