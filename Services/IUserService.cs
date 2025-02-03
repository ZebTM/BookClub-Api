using BookClub.Models;

namespace BookClub.Services;

public interface IUserService
{
    IEnumerable<User> GetAllUsers();
    User? GetUserById(Guid id);
    User InsertUser(User user);
    User? EditUser(User user);
    User? DeleteUser(User user);
}
