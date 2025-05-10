using Microsoft.AspNetCore.Mvc;
using BookClub.Models;
using BookClub.Services;
namespace BookClub.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{
    private IAuthorService _authorService;

    public AuthorController(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAuthors()
    {
        IEnumerable<Author> authors = await _authorService.GetAllAuthors();
        return Ok(authors);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAuthorById(Guid id)
    {

        Author? author = await _authorService.GetAuthorById(id);

        return Ok(author);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAuthor(CreateAuthor authorInfo)
    {
        Author? author = await _authorService.CreateAuthor(authorInfo);

        return Ok(author);

    }

    [HttpPut]
    public async Task<IActionResult> EditAuthor(Author author)
    {
        Author? editedAuthor = await _authorService.EditAuthor(author);

        return Ok(author);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAuthor(Guid id)
    {
        Author? deletedAuthor = await _authorService.DeleteAuthor(id);

        return Ok(deletedAuthor);

    }
}
