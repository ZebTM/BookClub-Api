using BookClub.Models;

namespace BookClub.Services;

public interface IAuthorService
{
    Task<IEnumerable<Author>> GetAllAuthors();
    Task<Author?> GetAuthorById(Guid id);
    Task<Author> CreateAuthor(CreateAuthor author);
    Task<Author?> EditAuthor(Author author);
    Task<Author?> DeleteAuthor(Guid id);
}

