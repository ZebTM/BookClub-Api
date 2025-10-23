using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using BookClub.Models;

namespace BookClub.Services;

public class TokenService : ITokenService
{
    private readonly IConfiguration _configuration;

    public TokenService(IConfiguration config )
    {
        _configuration = config;
    }

    public string GenerateToken(User user)
    {
        string? audience = _configuration["Jwt:Audience"];
        string? subject = _configuration["Jwt:Subject"];
        string? keyValue = _configuration["Jwt:Key"];
        string? issuer = _configuration["Jwt:Issuer"];
        int expireTime = Convert.ToInt16(_configuration["Jwt:ExpireMinutes"] ?? "60");

        if (audience == null || subject == null || keyValue == null || issuer == null)
        {
            throw new InvalidOperationException("JWT configuration is missing.");
        }

        var claims = new[] {
            new Claim(JwtRegisteredClaimNames.Sub, subject),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
            new Claim("UserId", user.Id.ToString()),
            new Claim("Username", user.Username),
            new Claim("Email", user.Email)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyValue));
        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            issuer,
            audience,
            claims,
            expires: DateTime.UtcNow.AddMinutes(expireTime),
            signingCredentials: signIn);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}