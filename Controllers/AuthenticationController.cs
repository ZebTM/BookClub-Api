using Microsoft.AspNetCore.Mvc;
using BookClub.Models;
using BookClub.Services;

namespace BookClub.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticatorController : ControllerBase
{
    public AuthenticatorController()
    {

    }

    [HttpPost("{UserName}")]
    public async Task<IActionResult> ForgetPassword(string UserName, string NewPassword)
    {
        throw new NotImplementedException();
    }


}
