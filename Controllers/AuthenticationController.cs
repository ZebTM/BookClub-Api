using Microsoft.AspNetCore.Mvc;
using BookClub.Models;
using BookClub.Services;
using Microsoft.AspNetCore.Identity;

namespace BookClub.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticatorController : ControllerBase
{
    private IUserService _userService;
    private IPasswordHasher<User> _passwordHasher;
    private ITokenService _tokenService;
    public AuthenticatorController(IUserService userService, IPasswordHasher<User> passwordHasher, ITokenService tokenService)
    {
        _userService = userService;
        _passwordHasher = passwordHasher;
        _tokenService = tokenService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginUser(UserCredentials credentials)
    {
        string username = credentials.Username;
        string givenPassword = credentials.Password;

        User? user = await _userService.GetUserByUsername(username);

        if (user == null)
        {
            return NotFound();
        }


        PasswordVerificationResult result = _passwordHasher
        .VerifyHashedPassword(user, user.HashedPassword, givenPassword);

        switch (result)
        {
            case PasswordVerificationResult.Success:
                string authToken = _tokenService.GenerateToken(user);


                return Ok(
                    authToken
                );

            case PasswordVerificationResult.Failed:
                return Unauthorized();

            case PasswordVerificationResult.SuccessRehashNeeded:
                return Ok();
        }

        return Unauthorized();

    }

    [HttpPost("{UserName}")]
    public async Task<IActionResult> ForgetPassword(string UserName, string NewPassword)
    {
        throw new NotImplementedException();
    }


}
