using BookClub.Models;

namespace BookClub.Services;

public interface ITokenService
{
    string GenerateToken(User user);
}
