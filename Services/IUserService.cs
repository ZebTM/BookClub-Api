using BookClub.Models;

namespace BookClub.Services;

public interface IUserService
{
    Task<IEnumerable<SanitizedUser>> GetAllUsers();
    Task<SanitizedUser?> GetUserById(Guid id);
    Task<SanitizedUser> CreateUser(User user);
    Task<SanitizedUser?> EditUser(SanitizedUser user);
    Task<SanitizedUser?> DeleteUser(Guid id);
    Task<User?> GetUserByUsername(String Username);

}
