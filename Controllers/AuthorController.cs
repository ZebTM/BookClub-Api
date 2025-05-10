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
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAuthorById(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAuthor(Author author)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    public async Task<IActionResult> EditAuthor(Author author)
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAuthor(Guid id)
    {
        throw new NotImplementedException();
    }
}
