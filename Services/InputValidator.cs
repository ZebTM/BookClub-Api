using System.Text.RegularExpressions;

namespace BookClub.Services;


public static class InputValidator
{

    // Passwords must be greater than 8 >= characters
    // Contain 1+ upper 1+ lower
    // 1+ Symbol
    // 1+ Number
    public static bool ValidatePassword(string Password)
    {
        return Regex.IsMatch(Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
    }

    public static bool ValidateUsername(string Username)
    {
        return Regex.IsMatch(Username, @"^[A-Za-z\d@$!%*?&]{3,25}$");
    }
}
