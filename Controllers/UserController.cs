using Microsoft.AspNetCore.Mvc;
using BookClub.Models;

namespace BookClub.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IEnumerable<User> _userList;

    public UserController()
    {
        _userList = [
            new User
            {
                Id = new Guid("9f1de15c-4cf9-4b3b-b55c-e93bc2dfd896"),
                Username = "Test"
            }
        ];
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(_userList);
    }
}
