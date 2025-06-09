using Microsoft.AspNetCore.Identity;
using System.Text.RegularExpressions;
using BookClub.Models;

namespace BookClub.Services;

public class PasswordHasher : IPasswordHasher<User>
{

    public string HashPassword(User user, string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public PasswordVerificationResult VerifyHashedPassword(User user, string hashedPassword, string providedPassword)
    {

        bool verificationResult = BCrypt.Net.BCrypt.Verify(providedPassword, hashedPassword);

        if (verificationResult)
        {
            return PasswordVerificationResult.Success;
        }
        else
        {
            return PasswordVerificationResult.Failed;
        }

    }
}



