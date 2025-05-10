using Microsoft.AspNetCore.Mvc;
using BookClub.Models;
using BookClub.Services;
namespace BookClub.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        return Ok(await _userService.GetAllUsers());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        SanitizedUser? foundUser = await _userService.GetUserById(id);

        if (foundUser == null)
        {
            return NotFound();
        }

        return Ok(await _userService.GetUserById(id));
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUser user)
    {
        return Ok(await _userService.CreateUser(user));
    }

    [HttpPut]
    public async Task<IActionResult> EditUser(SanitizedUser user)
    {
        SanitizedUser? editedUser = await _userService.EditUser(user);

        if (editedUser == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        SanitizedUser? deletedUser = await _userService.DeleteUser(id);
        return Ok(deletedUser);
    }

    [HttpPut("id")]
    public async Task<IActionResult> ResetUserPassword(string password)
    {
        throw new NotImplementedException();
    }
}
