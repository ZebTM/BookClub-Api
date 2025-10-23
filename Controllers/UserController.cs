using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using BookClub.Models;
using BookClub.Services;
using System.IdentityModel.Tokens.Jwt;

namespace BookClub.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private IUserService _userService;
    private IPasswordHasher<User> _passwordHasher;

    public UserController(IUserService userService, IPasswordHasher<User> passwordHasher)
    {
        _userService = userService;
        _passwordHasher = passwordHasher;
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
    public async Task<IActionResult> CreateUser(CreateUser userInfo)
    {

        if (!InputValidator.ValidatePassword(userInfo.Password))
        {
            return BadRequest("Bad Password");
        }

        if (!InputValidator.ValidateUsername(userInfo.Username))
        {
            return BadRequest("Bad Email");
        }

        User newUser = new User(userInfo);
        newUser.HashedPassword = _passwordHasher.HashPassword(newUser, newUser.HashedPassword);

        return Ok(await _userService.CreateUser(newUser));
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
}
